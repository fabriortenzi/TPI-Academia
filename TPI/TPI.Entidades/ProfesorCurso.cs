using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class ProfesorCurso
    {
        [Column(Order = 0)]
        public int Legajo { get; set; }

        [Column(Order = 1)]
        public int idMateria { get; set; }

        [Column(Order = 2)]
        public int Anio { get; set; }


        [ForeignKey("Legajo")]
        public Usuario Usuario { get; set; }

        [ForeignKey("idMateria, Anio")]
        public Curso Curso { get; set; }


        public String Cargo { get; set; }
    }
}
