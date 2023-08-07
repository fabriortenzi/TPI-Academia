using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Plan
    {        
        public int anio { get; private set; }

        public string descPlan { get; private set; }

        public TPI.Entidades.Especialidad especialidad { get; private set; }

        public Plan (int anioP, string desc_plan, Especialidad Especialidad)
        {
            anio = anioP;
            descPlan = desc_plan;
            especialidad = Especialidad;
        }
    }
}
