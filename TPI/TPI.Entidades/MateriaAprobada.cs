using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class MateriaAprobada
    {
        [Column(Order = 0)]
        public int Legajo { get; set; }
        
        [Column(Order = 1)]
        public int idMateria { get; set; }

        [ForeignKey("Legajo")]
        public Usuario Usuario { get; set; }

        [ForeignKey("idMateria")]
        public Materia Materia { get; set; }
        public int Nota { get; set; }
    }
}
