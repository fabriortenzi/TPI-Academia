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
        public static void AgregarMateria (TPI.Entidades.Materia materia)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.materias.Attach(materia);
                context.Entry(materia).State = EntityState.Added;
                context.SaveChanges();
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
                    x => x.descMateria == descripcionMateriaSelecc 
                    && x.Plan.IdEspecialidad == plan.IdEspecialidad
                    && x.Plan.anio == plan.anio);
            }
        }

        public static Entidades.Materia GetMateriaPorDesc(string desc_materia) 
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.materias.FirstOrDefault(x => x.descMateria == desc_materia);
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
