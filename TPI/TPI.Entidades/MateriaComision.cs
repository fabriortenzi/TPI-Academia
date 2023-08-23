using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPI.Entidades
{
    public class MateriaComision
    {
        [Column(Order = 0)]
        public int idMateria { get; set; }

        [Column(Order = 1)]
        public int idEspecialidad { get; set; }

        [Column(Order = 2)]
        public int IdCom { get; set; }

        [ForeignKey("idMateria")]
        public Materia Materia { get; set; }

        [ForeignKey("IdCom, idEspecialidad")]
        public Comisiones Comisiones { get; set; }

        public int Cupo { get; set; }

        public int dia { get; set; }

        public TimeSpan hora_ini { get; set; }

        public TimeSpan hora_fin { get; set; }
    }
}
