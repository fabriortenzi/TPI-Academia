using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Cursado
    {
        private static SqlConnection conn = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=tpi2023tm01;Integrated Security=true;");

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
