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
        public static List<Entidades.TipoDeUsuario> tiposDeUsuario = new List<Entidades.TipoDeUsuario>();

        public static void InicializarTiposDeUsuario()
        {
            Entidades.TipoDeUsuario alumno = new Entidades.TipoDeUsuario("Alumno");
            Entidades.TipoDeUsuario profesor = new Entidades.TipoDeUsuario("Profesor");
            Entidades.TipoDeUsuario admin = new Entidades.TipoDeUsuario("Admin");

            tiposDeUsuario.Add(alumno);
            tiposDeUsuario.Add(profesor);
            tiposDeUsuario.Add(admin);
        }

        public static Entidades.TipoDeUsuario GetTipoAlumno() => tiposDeUsuario.FirstOrDefault(x => x.Descripcion == "Alumno");

        public static Entidades.TipoDeUsuario GetTipoProfesor() => tiposDeUsuario.FirstOrDefault(x => x.Descripcion == "Profesor");

        public static Entidades.TipoDeUsuario GetTipoAdmin() => tiposDeUsuario.FirstOrDefault(x => x.Descripcion == "Admin");

        public static List<Entidades.TipoDeUsuario> GetAllTiposDeUsuario() => tiposDeUsuario;

        public static Entidades.TipoDeUsuario GetTipoUsuarioPorDescripcion(string descripcion)
            => tiposDeUsuario.FirstOrDefault(x => x.Descripcion == descripcion);
    }
}
