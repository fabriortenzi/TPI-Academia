using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Materia
    {
        [Key]
        [Column(Order = 0)]
        public int idMateria { get; private set; }

        [Column(Order = 1)]
        public int IdEspecialidad { get; private set; }

        [Column(Order = 2)]
        public int anio { get; private set; }

        [ForeignKey("IdEspecialidad, anio")]
        public Plan Plan { get; private set; }

        public string descMateria { get; private set; }

        public int horaSem { get; private set; }

        public int horaTot { get; private set; }

        public Materia() { }

        public Materia (string desc, int hora_sem, int hora_tot, Plan plan)
        {
            descMateria = desc;
            horaSem = hora_sem;
            horaTot = hora_tot;
            Plan = plan;
        }
    }
}
