using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Modulo
    {
        private static List<Entidades.Modulo> Modulos = new List<Entidades.Modulo>();

        public static void InicializarListaModulos()
        {
            Entidades.Modulo moduloPersona = new("Persona", "");
            Entidades.Modulo moduloUsuario = new("Usuario", "");
            Entidades.Modulo moduloInscripcionCursado = new("Inscripcion", "");
            Entidades.Modulo moduloPlan = new("Plan de Estudio", "");
            Entidades.Modulo moduloCurso = new("Curso", "");

            Modulos.Add(moduloPersona);
            Modulos.Add(moduloUsuario);
            Modulos.Add(moduloInscripcionCursado);
            Modulos.Add(moduloPlan);
            Modulos.Add(moduloCurso);
        }

        public static void AgregarModulo(Entidades.Modulo modulo)
        {
            Modulos.Add(modulo);
        }

        public static List<Entidades.Modulo> GetAllModulos()
            => Modulos;

        public static Entidades.Modulo GetModuloPersona()
            => Modulos.FirstOrDefault(x => x.Descripcion == "Persona");

        public static Entidades.Modulo GetModuloUsuario()
            => Modulos.FirstOrDefault(x => x.Descripcion == "Usuario");

        public static Entidades.Modulo GetModuloInscripcionCursado()
            => Modulos.FirstOrDefault(x => x.Descripcion == "Inscripcion");

        public static Entidades.Modulo GetModuloPlan()
            => Modulos.FirstOrDefault(x => x.Descripcion == "Plan de Estudio");

        public static Entidades.Modulo GetModuloCurso()
            => Modulos.FirstOrDefault(x => x.Descripcion == "Curso");
    }
}
