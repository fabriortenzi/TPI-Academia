using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Planes
    {

        private static List<Entidades.Planes> planes = new List<Entidades.Planes>();

        public static void AgregarPlanes(Entidades.Planes plan)
        {
            planes.Add(plan);
        }

        public static void InicializarListaPlanes()
        {
            Entidades.Planes plan1 = new(2008, "Plan 2008");

            Entidades.Planes plan2 = new(2023, "Plan 2023");


            AgregarPlanes(plan1);
            AgregarPlanes(plan2);


        }
        public static List<Entidades.Planes> GetPlanes()
        {
            return planes;
        }

        public static TPI.Entidades.Planes ObtenerPlanMasActual(List<Entidades.Planes> planes)
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