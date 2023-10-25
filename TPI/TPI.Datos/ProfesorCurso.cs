using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;
using System.Data;

namespace TPI.Datos
{
   
    public class ProfesorCurso
    {
        private static SqlConnection conn = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=tpi2023tm01;Integrated Security=true;");
        public static int BuscarCantProfesoresInsc(Entidades.Curso curso)
        {
            int cantProfes = 0;
            SqlCommand mycommand = new SqlCommand();
            mycommand.Connection = conn;
            mycommand.Parameters.Add("@Id", SqlDbType.Int).Value = curso.Id;
            mycommand.CommandText = "SELECT Count(p.Id) FROM profesores_cursos AS p WHERE p.CursoId = @Id";

            try { 
            conn.Open();
            cantProfes = Convert.ToInt32(mycommand.ExecuteScalar());
            }
            catch{ }
            finally 
            {
                conn.Close();
            }
            return cantProfes;
        }
        public static void Agregar(Entidades.ProfesorCurso profesor_curso)
        {
           using (var context = ApplicationContext.CreateContext())
            {
                context.profesores_cursos.Attach(profesor_curso);
                context.Entry(profesor_curso).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public static Entidades.ProfesorCurso GetOne(int id)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.profesores_cursos
                    .Include(x=>x.Curso)
                    .Include(x => x.Usuario)
                    .FirstOrDefault(x => x.Id == id);
            }
        }

        public static List<Entidades.ProfesorCurso> GetAll()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.profesores_cursos
                    .Include(x => x.Curso)
                    .ThenInclude(x => x.Materia)
                    .Include(x => x.Curso.Comision)
                    .Include(x => x.Usuario)
                    .ThenInclude(x => x.Persona)
                    .ToList();
            }
        }

        public static void Cambiar(Entidades.ProfesorCurso profesor_curso, string cargo, Entidades.Usuario usuario, Entidades.Curso curso)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                Entidades.ProfesorCurso profesor_cursoCambiar = context.profesores_cursos.FirstOrDefault(x => x == profesor_curso);
                

                    profesor_cursoCambiar.Cargo = cargo;
                    profesor_cursoCambiar.Usuario = usuario;
                    profesor_cursoCambiar.Curso = curso;

                context.SaveChanges();
                
            }
        }

        public static void Eliminar(Entidades.ProfesorCurso profesor_curso)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.profesores_cursos.Remove(profesor_curso);
                context.SaveChanges();             
            }
        }

    }
}
