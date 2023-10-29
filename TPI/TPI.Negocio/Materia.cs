using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Materia
    {
        public static Entidades.Materia? GetOne(int id)
            => Datos.Materia.GetOne(id);

        public static Entidades.Materia CrearMateria(string descMat, int hor_sem, int hor_tot, Entidades.Plan plan)
        {
            Entidades.Materia materia = new(descMat, hor_sem, hor_tot, plan);
            return materia;
        }

        public async static Task<bool> AgregaMateria(TPI.Entidades.Materia materia)
        {
            return await TPI.Datos.Materia.AgregarMateria(materia);
        }

        public static List<Entidades.Materia> GetMateriasPorPlan(Entidades.Plan plan)
            => Datos.Materia.GetMateriasPorPlan(plan);

        public static Entidades.Materia GetMateriaPorDescripcionYPlan(string descripcionMateriaSelecc, Entidades.Plan plan)
            => Datos.Materia.GetMateriaPorDescripcionYPlan(descripcionMateriaSelecc, plan);

        public static Entidades.Materia GetMateriaPorDesc(string desc_materia) 
        {
            return Datos.Materia.GetMateriaPorDesc(desc_materia);
        }

        public static List<Entidades.Materia> GetAll() 
        {
            return Datos.Materia.GetAll();
        }

    }
}
