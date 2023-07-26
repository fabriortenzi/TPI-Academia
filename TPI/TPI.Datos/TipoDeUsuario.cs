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
            Entidades.TipoDeUsuario alumno = new Entidades.TipoDeUsuario("alumno");
            Entidades.TipoDeUsuario profesor = new Entidades.TipoDeUsuario("profesor");
            Entidades.TipoDeUsuario admin = new Entidades.TipoDeUsuario("admin");

            tiposDeUsuario.Add(alumno);
            tiposDeUsuario.Add(profesor);
            tiposDeUsuario.Add(admin);
        }

        public static Entidades.TipoDeUsuario GetTipoAlumno() => tiposDeUsuario.FirstOrDefault(x => x.Descripcion == "alumno");

        public static Entidades.TipoDeUsuario GetTipoProfesor() => tiposDeUsuario.FirstOrDefault(x => x.Descripcion == "profesor");

        public static Entidades.TipoDeUsuario GetTipoAdmin() => tiposDeUsuario.FirstOrDefault(x => x.Descripcion == "admin");
    }
}
