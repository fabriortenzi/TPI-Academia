using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class InscripcionCursado
    {
        public static Entidades.InscripcionCursado CrearInscripcion(Entidades.Curso curso, Entidades.Usuario usuario, Entidades.Comisiones comision)
            => new Entidades.InscripcionCursado(curso, usuario, comision);

        public static void AgregarInscripcion(Entidades.InscripcionCursado inscripcion)
        {
            Datos.InscripcionCursado.AgregarInscripcion(inscripcion);
        }



        public static List<Entidades.InscripcionCursado> GetAllInscripcion()
        {
            return Datos.InscripcionCursado.GetAllInscripcion();

        }

        public static List<Entidades.Usuario> GetAllAlumnosPorMateria(Entidades.Materia materia)
        {
            return Datos.InscripcionCursado.GetAllAlumnosPorMateria(materia);

        }


    }
}
