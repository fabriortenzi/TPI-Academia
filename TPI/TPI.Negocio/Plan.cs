using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Plan
    {
        public static Entidades.Plan CrearPlan(int año , string descplan)
        {
            Entidades.Plan plan = new(año, descplan);
            return plan;
        }

        public static void AgregoPlan (TPI.Entidades.Plan plan)
        {
            TPI.Datos.Plan.AgregarPlanes(plan);
        }

        public static List<Entidades.Plan> GetPlanesPorEspecialidad(Entidades.Especialidad especialidad)
            => Datos.Plan.GetPlanesPorEspecialidad(especialidad);
    }
}
