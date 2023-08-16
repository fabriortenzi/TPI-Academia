using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Curso
    {
        [Key]
        [Column(Order = 1)]
        public int IdMateria { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Año { get; private set; }

        [ForeignKey("IdMateria")]
        public Materia Materia { get; private set; }

        public int Cupo { get; private set; }

        public Curso() { }

        public Curso(Materia materia, int año, int cupo)
        {
            Materia = materia;
            Año = año;
            Cupo = cupo;
        }
    }
}
