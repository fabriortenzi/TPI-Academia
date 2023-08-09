using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Materia
    {
        public static Entidades.Materia CrearMateria(string descMat, int hor_sem, int hor_tot, Entidades.Plan plan)
        {
            Entidades.Materia materia = new(descMat, hor_sem, hor_tot, plan);
            return materia;
        }

        public static void AgregaMateria(TPI.Entidades.Materia materia)
        {
            TPI.Datos.Materia.AgregarMateria(materia);
        }

        public static List<Entidades.Materia> Getallmaterias() => Datos.Materia.GetMaterias();

        public static List<Entidades.Materia> GetMateriasPorPlan(Entidades.Plan plan)
            => Datos.Materia.GetMateriasPorPlan(plan);

        public static Entidades.Materia GetMateriaPorDescripcionYPlan(string descripcionMateriaSelecc, Entidades.Plan plan)
            => Datos.Materia.GetMateriaPorDescripcionYPlan(descripcionMateriaSelecc, plan);
    }
}
