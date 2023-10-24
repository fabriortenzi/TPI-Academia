using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Curso
    {
        public static void DescontarCupo(Entidades.Curso curso)
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                Entidades.Curso cursoAcambiar = GetOne(curso.Id);
               if (cursoAcambiar.Cupo > 0) { 
               cursoAcambiar.Cupo = cursoAcambiar.Cupo - 1;
               }
               else { }
                context.SaveChanges();
            }
        }
        public static void Agregar(Entidades.Curso curso)
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
                    .Include(c => c.Comision)
                    .Where(c => c.CicloLectivo == añoActual
                            && c.Materia.Plan.Equals(plan)
                            && c.Cupo > 0).ToList();

                return cursosDisponibles;
            }
        }

        public static List<Entidades.Curso> GetAll()
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.cursos
                    .Include(x => x.Materia)
                    .ThenInclude(x => x.Plan)
                    .ThenInclude(x => x.Especialidad)
                    .Include(x => x.Comision)
                    .ToList();
            }
        }

        public static Entidades.Curso GetOne(int id) 
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.cursos
                       .Include(x => x.Materia)
                      .ThenInclude(x => x.Plan)
                       .Include(x => x.Comision)
                       .ThenInclude(x => x.Especialidad)
                       .FirstOrDefault(x => x.Id == id);

            }

        }

        public static void Cambiar(Entidades.Curso curso) 
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                context.cursos.Attach(curso);
                context.Entry(curso).State = EntityState.Modified;
                context.SaveChanges();
            }


        }

        public static void Eliminar(Entidades.Curso curso)
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                context.cursos.Remove(curso);
                context.SaveChanges();
            }
        }

    }
}
