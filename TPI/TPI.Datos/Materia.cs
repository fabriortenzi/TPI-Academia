using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TPI.Datos
{
    public class Materia
    {
        public static Entidades.Materia GetOne(int id)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.materias
                    .Include(x => x.Plan)
                    .FirstOrDefault(x=>x.Id == id);
            }
        }

        public async static Task<bool> AgregarMateria (TPI.Entidades.Materia materia)
        {
            try
            {
                using (var context = ApplicationContext.CreateContext())
                {
                    var materiaE = GetMateriaPorDescripcionYPlan(materia.Descripcion, materia.Plan);
                    if (materiaE != null)
                    {
                        return false;
                    }

                    context.materias.Attach(materia);
                    context.Entry(materia).State = EntityState.Added;
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        } 
        public static List<Entidades.Materia> GetMateriasPorPlan(Entidades.Plan plan)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.materias.Where(x => x.Plan == plan).ToList();
            }
        }

        public static Entidades.Materia GetMateriaPorDescripcionYPlan(string descripcionMateriaSelecc, Entidades.Plan plan)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.materias.FirstOrDefault(
                    x => x.Descripcion == descripcionMateriaSelecc 
                    && x.Plan.Especialidad.Id == plan.Especialidad.Id
                    && x.Plan.Anio == plan.Anio);
            }
        }

        public static Entidades.Materia GetMateriaPorDesc(string desc_materia) 
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.materias.FirstOrDefault(x => x.Descripcion == desc_materia);
            }
        }

        public static List<Entidades.Materia> GetAll() 
        {
            List<Entidades.Materia> materias = new();
            using (var context = ApplicationContext.CreateContext()) 
            {
                materias = context.materias.ToList();
            }
            return materias;
        }
    }
}
