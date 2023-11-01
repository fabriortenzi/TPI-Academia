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
        public static Entidades.Plan? GetOne(int Id) 
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.planes
                    .Include(x => x.Especialidad)
                    .FirstOrDefault(x => x.Id == Id);
            }

        }

        public async static Task<bool> AgregarPlanes(Entidades.Plan plan)
        {
            try
            {
                using (var context = ApplicationContext.CreateContext())
                {
                    var planE = await GetPlanPorEspecialidadAnio(plan.Especialidad, plan.Anio);
                    if (planE != null)
                    {
                        return false;
                    }

                    context.planes.Attach(plan);
                    context.Entry(plan).State = EntityState.Added;
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static List<Entidades.Plan> GetPlanesPorEspecialidad(Entidades.Especialidad Especialidad)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.planes
                    .Include(x => x.Especialidad)
                    .Where(x => x.Especialidad.Descripcion == Especialidad.Descripcion).ToList();
            }
        }

        public async static Task<Entidades.Plan> GetPlanPorEspecialidadAnio(Entidades.Especialidad Especialidad, int Anio)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return await context.planes
                    .Include(x => x.Especialidad)
                    .FirstOrDefaultAsync(x => x.Especialidad.Descripcion == Especialidad.Descripcion && x.Anio == Anio);
            }
        }

        public static List<Entidades.Plan> GetAll()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.planes
                    .Include(p => p.Especialidad)
                    .ToList();
            }
        }
    }
}