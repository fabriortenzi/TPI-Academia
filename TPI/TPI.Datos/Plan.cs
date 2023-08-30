using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Plan
    {
        public static void AgregarPlanes(Entidades.Plan plan)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.planes.Attach(plan);
                context.Entry(plan).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public static List<Entidades.Plan> GetPlanesPorEspecialidad(Entidades.Especialidad Especialidad)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.planes
                    .Include(x => x.especialidad)
                    .Where(x => x.especialidad.descEspec == Especialidad.descEspec).ToList();
            }
        }

        public static Entidades.Plan GetPlanPorEspecialidadAnio(Entidades.Especialidad Especialidad, int Anio)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.planes
                    .Include(x => x.especialidad)
                    .FirstOrDefault(x => x.especialidad.descEspec == Especialidad.descEspec && x.anio == Anio);
            }
        }
    }
}