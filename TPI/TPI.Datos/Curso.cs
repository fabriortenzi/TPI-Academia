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
        private static List<Entidades.Curso> cursos = new();

        public static void AgregarCurso(Entidades.Curso curso)
        {
            cursos.Add(curso);
        }

        public static List<Entidades.Curso> GetCursosPorPlanYAñoActual(Entidades.Plan plan)
        {
            DateTime fechaActual = DateTime.Today;
            int añoActual = fechaActual.Year;

            var cursosDisponibles = cursos.Where(c => c.Año == añoActual
                && c.Materia.Plan.Equals(plan)
                && c.Cupo > 0).ToList();

            return cursosDisponibles;
        }
    }
}
