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

        [Column(Order = 0)]
        public int idEvaluacion { get; set; }

        [Column(Order = 1)]
        public int LegajoUsuario { get;  set; }
        
        [Column(Order = 2)]
        public DateTime FechaHora { get; set; }

        [ForeignKey("LegajoUsuario, FechaHora")]
        public InscripcionCursado InscripcionCursado { get; set; }



        public int Nota { get;  set; }

    }
}
