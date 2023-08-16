using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class TipoDeUsuario
    {
        public static Entidades.TipoDeUsuario GetTipoAlumno()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.tipos_de_usuario.FirstOrDefault(x => x.Descripcion == "Alumno");
            }
        }

        public static Entidades.TipoDeUsuario GetTipoProfesor()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.tipos_de_usuario.FirstOrDefault(x => x.Descripcion == "Profesor");
            }
        }

        public static Entidades.TipoDeUsuario GetTipoAdmin()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.tipos_de_usuario.FirstOrDefault(x => x.Descripcion == "Admin");
            }
        }

        public static List<Entidades.TipoDeUsuario> GetAllTiposDeUsuario()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.tipos_de_usuario.ToList();
            }
        }

        public static Entidades.TipoDeUsuario GetTipoUsuarioPorDescripcion(string descripcion)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.tipos_de_usuario.FirstOrDefault(x => x.Descripcion == descripcion);
            }
        }
    }
}
