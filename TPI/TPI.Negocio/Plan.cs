using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Plan
    {
        public static Entidades.Plan CrearPlan(int año, Entidades.Especialidad especialidad)
        {
            Entidades.Plan plan = new(año, especialidad);
            return plan;
        }

        public async static Task<bool> AgregoPlan (TPI.Entidades.Plan plan)
        {
            return await TPI.Datos.Plan.AgregarPlanes(plan);
        }

        public static List<Entidades.Plan> GetPlanesPorEspecialidad(Entidades.Especialidad especialidad)
            => Datos.Plan.GetPlanesPorEspecialidad(especialidad);

        public static Task<Entidades.Plan> GetPlanPorEspecialidadAnio(Entidades.Especialidad especialidad, int año)
        { return Datos.Plan.GetPlanPorEspecialidadAnio(especialidad, año); }
        public static List<Entidades.Plan> GetAll()
        {
            return Datos.Plan.GetAll();
        }
    }

   
}
