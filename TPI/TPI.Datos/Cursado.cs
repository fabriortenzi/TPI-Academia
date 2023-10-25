using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Cursado
    {
        private static SqlConnection conn = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=tpi2023tm01;Integrated Security=true;");

        public static decimal DesAprobado(Entidades.Curso curso)
        {
            int aux = 0;
            var cursos = BuscarCursadosPorCurso(curso);
            foreach (var c in cursos)
            {
                if (c.NotaFinal < 6)
                {
                    aux = aux + 1;
                }
            }
            return Convert.ToDecimal(aux / cursos.Count());
        }
        public static decimal PorceAprobado(Entidades.Curso curso)
        {
            int aux = 0;
            var cursos = BuscarCursadosPorCurso(curso);
            foreach (var c in cursos) 
            {
                if (c.NotaFinal<=6) 
                {
                    aux = aux + 1;
                }
            }
            return Convert.ToDecimal(aux / cursos.Count());
        }
        public static List<Entidades.Cursado> BuscarCursadosPorCurso(Entidades.Curso curso) 
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.cursados.Where(x=>x.Curso.Id == curso.Id)
                     .Include(x => x.Usuario)
                     .ThenInclude(x => x.Persona)
                     .Include(x => x.Curso)
                     .ThenInclude(x => x.Materia)
                     .ToList();
            }
        }
        

        public static int BuscarCantAlumnosInsc(Entidades.Curso curso) 
        {

            int cantAlu = 0;
            SqlCommand mycommand = new SqlCommand();
            mycommand.Connection = conn;
            mycommand.Parameters.Add("@Id", SqlDbType.Int).Value = curso.Id;
            mycommand.CommandText = "SELECT Count(c.Id) FROM cursados AS c WHERE c.CursoId = @Id";

            try
            {
                conn.Open();
                cantAlu = Convert.ToInt32(mycommand.ExecuteScalar());
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return cantAlu;
        }

        public static void Agregar(Entidades.Cursado cursado) 
        {            
            try
            {
                conn.Open();
                string query = "INSERT INTO cursados (UsuarioLegajo, CursoId, FechaHoraInscripcion)" +
                               "VALUES (@UsuarioLegajo, @CursoId, @FechaHoraInscripcion)";
                
                SqlParameter UsuarioLegajo = new("@UsuarioLegajo", cursado.Usuario.Legajo);
                SqlParameter CursoId = new("@CursoId", cursado.Curso.Id);
                SqlParameter FechaHoraInscripcion = new("@FechaHoraInscripcion", cursado.FechaHoraInscripcion);

                SqlCommand command = new(query, conn);
                command.Parameters.Add(UsuarioLegajo);
                command.Parameters.Add(CursoId);
                command.Parameters.Add(FechaHoraInscripcion);

                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void Eliminar(Entidades.Cursado cursado)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.Remove(cursado);
                context.SaveChanges();
            }
        }

        public static void Cambiar(Entidades.Cursado cursado)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.cursados.Attach(cursado);
                context.Entry(cursado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static Entidades.Cursado GetOne(int id)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.cursados
                    .Include(x=>x.Usuario)                    
                    .Include(x => x.Curso)
                    .FirstOrDefault(x=>x.Id == id);                
            }

        }
        public static List<Entidades.Cursado> GetAll()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.cursados
                     .Include(x => x.Usuario)
                     .ThenInclude(x => x.Persona)
                     .Include(x => x.Curso)
                     .ThenInclude(x => x.Materia)
                     .ToList();
            }
        }
    }
}
