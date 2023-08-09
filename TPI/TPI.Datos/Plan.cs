using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Plan
    {
        private static List<Entidades.Plan> planes = new List<Entidades.Plan>();

        public static void AgregarPlanes(Entidades.Plan plan)
        {
            planes.Add(plan);
        }

        public static void InicializarListaPlanes()
        {
            Entidades.Especialidad esp1 = Especialidades.GetEspecialidad("Ingenieria en Sistemas");
            Entidades.Especialidad esp2 = Especialidades.GetEspecialidad("Ingenieria Quimica");

            Entidades.Plan plan1 = new(2008, "Plan 2008", esp1 );
            Entidades.Plan plan2 = new(2023, "Plan 2023", esp2 );

            AgregarPlanes(plan1);
            AgregarPlanes(plan2);
        }

        public static List<Entidades.Plan> GetPlanes()
        {
            return planes;
        }

        public static List<Entidades.Plan> GetPlanesPorEspecialidad(Entidades.Especialidad Especialidad)
            => planes.Where(x => x.especialidad == Especialidad).ToList();

        public static Entidades.Plan GetPlanPorEspecialidadA�o(Entidades.Especialidad Especialidad, int A�o)
            => planes.FirstOrDefault(x => x.especialidad == Especialidad && x.anio == A�o);
    }
}