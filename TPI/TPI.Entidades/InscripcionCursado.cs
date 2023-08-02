using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class InscripcionCursado
    {
        public Curso Curso { get; private set; }

        public Usuario Usuario { get; private set; }

        public Comisiones Comision { get; private set; }

        public DateTime FechaHora { get; private set; }

        public InscripcionCursado(Curso curso, Usuario usuario, Comisiones comision, DateTime fechaHora)
        {
            Curso = curso;
            Usuario = usuario;
            Comision = comision;
            FechaHora = fechaHora;
        }
    }
}
