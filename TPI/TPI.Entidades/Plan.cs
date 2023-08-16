using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Plan
    {
        [Key]
        [Column(Order = 0)]
        public int IdEspecialidad { get; private set; }

        [Key]
        [Column(Order = 1)]
        public int anio { get; private set; }

        [ForeignKey("IdEspecialidad")]
        public TPI.Entidades.Especialidad especialidad { get; private set; }

        public string descPlan { get; private set; }

        public Plan() { }

        public Plan (int anioP, string desc_plan, Especialidad Especialidad)
        {
            anio = anioP;
            descPlan = desc_plan;
            especialidad = Especialidad;
        }
    }
}
