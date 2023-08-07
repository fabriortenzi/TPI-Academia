using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Plan
    {        
        public Especialidad Especialidad { get; private set; }
        
        public int anio { get; private set; }

        public string descPlan { get; private set; }

        public Plan (int anioP, string desc_plan, Especialidad especialidad)
        {
            anio = anioP;
            descPlan = desc_plan;
            Especialidad = especialidad;
        }

    }

}
