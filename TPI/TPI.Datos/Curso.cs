using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Curso
    {
        public static void AgregarCurso(Entidades.Curso curso)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.cursos.Attach(curso);
                context.Entry(curso).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public static List<Entidades.Curso> GetCursosPorPlanYAñoActual(Entidades.Plan plan)
        {
            DateTime fechaActual = DateTime.Today;
            int añoActual = fechaActual.Year;

            using (var context = ApplicationContext.CreateContext())
            {
                var cursosDisponibles = context.cursos
                    .Include(c => c.Materia)
                    .Where(c => c.Año == añoActual
                            && c.Materia.Plan.Equals(plan)
                            && c.Cupo > 0).ToList();

                return cursosDisponibles;
            }
        }

        public static List<Entidades.Curso> GetAll()
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.cursos.ToList();
            }
        }
    }
}
