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
        public int Id { get; }

        public int Nota { get;  set; }

        public int IdInscripcion { get;  set; }        

        [ForeignKey("IdInscripcion")]
        public InscripcionCursado InscripcionCursado { get; set; }
    }
}
