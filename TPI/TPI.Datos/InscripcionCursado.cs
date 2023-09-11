using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class InscripcionCursado
    {
        public static void AgregarInscripcion(Entidades.InscripcionCursado inscripcion)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.inscripciones_cursados.Attach(inscripcion);
                context.Entry(inscripcion).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public static List<Entidades.InscripcionCursado> GetAllInscripcion() 
        {
            List<Entidades.InscripcionCursado> incripciones = new();
            using (var context = ApplicationContext.CreateContext()) {
                if (context.inscripciones_cursados.ToList() != null) 
                { 
                incripciones = context.inscripciones_cursados.ToList();
                }
            }
            return incripciones;
        }

        public static List<Entidades.Usuario> GetAllAlumnosPorMateria(Entidades.Materia materia)
        {
            List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();
            using (var context = ApplicationContext.CreateContext())
            {
                var usuarios_inscriptos = from ins in context.inscripciones_cursados
                                          join usu in context.usuarios on ins.LegajoUsuario equals usu.Legajo
                                          where ins.Curso.Materia == materia
                                          select usu;
                                          

                usuarios = usuarios_inscriptos.ToList();
            }

            return usuarios;
        }

        public static List<Object> GetInscripcionesUsuarioAñoActual(Entidades.Usuario usuario)
        {
            List<Object> inscripciones = new();

            SqlConnection conn = new(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=tpi2023tm01;Integrated Security=true;");

            string query = @"SELECT ic.Id, IdComision, descMateria
                             FROM inscripciones_cursados ic
                             JOIN materias mat
                             ON ic.IdMateria = mat.idMateria
                             WHERE YEAR(FechaHora) = YEAR(GETDATE())
                             AND LegajoUsuario = @legajo;";

            try
            {
                conn.Open();
                SqlCommand command = new(query, conn);
                command.Parameters.Add(new SqlParameter("@legajo", usuario.Legajo));
                SqlDataReader reader =  command.ExecuteReader();

                while (reader.Read())
                {
                    inscripciones.Add(new
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        IdComision = int.Parse(reader["IdComision"].ToString()),
                        descMateria = reader["descMateria"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return inscripciones;
        }

        public static bool EliminarInscripcion(int idInscripcion)
        {
            SqlConnection conn = new(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=tpi2023tm01;Integrated Security=true;");

            string query = @"DELETE FROM inscripciones_cursados 
                             WHERE Id = @idInscripcion;";

            try
            {
                conn.Open();
                SqlCommand command = new(query, conn);
                command.Parameters.Add(new SqlParameter("@idInscripcion", idInscripcion));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
    }
}
