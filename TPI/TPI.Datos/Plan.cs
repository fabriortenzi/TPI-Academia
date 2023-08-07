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
            var isi = Datos.Especialidades.GetEspecialidadPorDescripcion("Ingenieria en Sistemas");
            var ic = Datos.Especialidades.GetEspecialidadPorDescripcion("Ingenieria Civil");

            Entidades.Plan plan2008isi = new(2008, "Plan 2008", isi);
            Entidades.Plan plan2023isi = new(2023, "Plan 2023", isi);

            Entidades.Plan plan2008ic = new(2008, "Plan 2008", ic);
            Entidades.Plan plan2023ic = new(2023, "Plan 2023", ic);


            AgregarPlanes(plan2008isi);
            AgregarPlanes(plan2023isi);
            AgregarPlanes(plan2008ic);
            AgregarPlanes(plan2023ic);

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

        public static List<Entidades.Plan> GetPlanesPorEspecialidad(Entidades.Especialidad especialidad)
            => planes.Where(x => x.Especialidad == especialidad).ToList();
    }
}