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
    }
}
