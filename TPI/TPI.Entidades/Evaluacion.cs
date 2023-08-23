using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Evaluacion
    {

        [Key]
        [Column(Order = 0)]
        public int idEvaluacion { get; set; }

        [Column(Order = 1)]
        public int Legajo { get;  set; }

        [Column(Order = 2)]
        public int idMateria { get;  set; }

        [Column(Order = 3)]
        public int Anio { get;  set; }

        
        [ForeignKey("Legajo, idMateria, Anio")]
        public Usuario Usuario { get; set; }



        public int Nota { get;  set; }

    }
}
