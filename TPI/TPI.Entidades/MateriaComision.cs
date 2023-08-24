using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class MateriaComision
    {
        [Key]
        [Column(Order = 0)]
        public int idMateria { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IdEspecialidad { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdCom { get; set; }

        [ForeignKey("idMateria")]
        public Materia Materia { get; set; }

        [ForeignKey("IdCom, IdEspecialidad")]
        public Comisiones Comisiones { get; set; }

        public int Cupo { get; set; }

        public int dia { get; set; }

        public TimeSpan hora_ini { get; set; }

        public TimeSpan hora_fin { get; set; }
    }
}
