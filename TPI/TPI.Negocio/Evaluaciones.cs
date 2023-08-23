using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Evaluaciones
    {

        public static void Agregar(Entidades.Evaluacion evaluacion)
        {
            TPI.Datos.Evaluaciones.Agregar(evaluacion);
        }

        public static Entidades.Evaluacion GetEvaluacion(int id_evaluacion)
        {
            return TPI.Datos.Evaluaciones.GetEvaluacion(id_evaluacion);
        }
        public static List<Entidades.Evaluacion> GetAllEvaluacion()
        {
            return TPI.Datos.Evaluaciones.GetAllEvaluaciones();
        }
        public static void Cambiar(Entidades.Evaluacion evaluacion, int nueva_nota)
        {
            TPI.Datos.Evaluaciones.Cambiar(evaluacion, nueva_nota);
        }
        public static void Eliminar(Entidades.Evaluacion evaluacion)
        {
            TPI.Datos.Evaluaciones.Eliminar(evaluacion);
        }
    }
}
