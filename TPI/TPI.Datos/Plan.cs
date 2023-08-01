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
            Entidades.Plan plan1 = new(2008, "Plan 2008");

            Entidades.Plan plan2 = new(2023, "Plan 2023");


            AgregarPlanes(plan1);
            AgregarPlanes(plan2);


        }
        public static List<Entidades.Plan> GetPlanes()
        {
            return planes;
        }

        public static TPI.Entidades.Plan ObtenerPlanMasActual(List<Entidades.Plan> planes)
        {

            if (planes.Count == 0)
            {
                return null;
            }


            planes.Sort((p1, p2) => p2.anio.CompareTo(p1.anio));


            return planes[0];
        }
    }
}