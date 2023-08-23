using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Evaluaciones
    {
        public static void Agregar(Entidades.Evaluacion evaluacion)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.evaluaciones.Add(evaluacion);
                context.SaveChanges();
            }
        }

        public static Entidades.Evaluacion GetEvaluacion(int legajo, int id_materia, int anio, int id_evaluacion)
        {
            Entidades.Evaluacion evaluacion = null;

            using (var context = ApplicationContext.CreateContext())
            {
                evaluacion = context.evaluaciones.FirstOrDefault(x => x.Legajo == legajo && x.idMateria == id_materia && x.Anio == anio && x.idEvaluacion == id_evaluacion );
            }

            return evaluacion;
        }


        public static List<Entidades.Evaluacion> GetAllEvaluaciones()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.evaluaciones.ToList();
            }
        }

        public static void Cambiar(Entidades.Evaluacion evaluacion, int nueva_nota)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var evaluacionCambiar = context.evaluaciones.FirstOrDefault(x => x == evaluacion);
                evaluacionCambiar.Nota = nueva_nota;
                context.SaveChanges();
            }
        }

        public static void Eliminar(Entidades.Evaluacion evaluacion)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var evaluacionEliminar = context.evaluaciones.FirstOrDefault(x => x == evaluacion);
                if (evaluacionEliminar != null)
                {
                    context.evaluaciones.Remove(evaluacionEliminar);
                    context.SaveChanges();
                }

            }


        }
    }
}
