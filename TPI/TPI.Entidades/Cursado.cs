using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Cursado
    {
        public int Id { get; }

        public Usuario Usuario { get; set; }

        public Curso Curso { get; set;}

        public DateTime FechaHoraInscripcion { get; set; }

        public int NotaFinal { get; set; }

        public Cursado(Usuario usuario, Curso curso, DateTime fechaHoraInscripcion, int notaFinal)
        {
            Usuario = usuario;
            Curso = curso;
            FechaHoraInscripcion = fechaHoraInscripcion;
            NotaFinal = notaFinal;
        }
    }
}
