using System.ComponentModel.DataAnnotations;
using System;

namespace AcademiaWeb.Models
{
        public class Cursado
        {
            public int Id { get; set; }

            public Usuario Usuario { get; set; }

            public Curso Curso { get; set; }

            public DateTime FechaHoraInscripcion { get; set; }

            public int NotaFinal { get; set; }
        }
}
