using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Materia
    {
        private static List<Entidades.Materia> materias = new List<Entidades.Materia>();

        public static void AgregarMateria (TPI.Entidades.Materia materia)
        {
            materias.Add(materia);
        } 

        public static void inicializarMaterias()
        {
            var isi = TPI.Datos.Especialidades.GetEspecialidad("Ingenieria en Sistemas");
            var iq = TPI.Datos.Especialidades.GetEspecialidad("Ingenieria Quimica");

            var plan2008isi = TPI.Datos.Plan.GetPlanPorEspecialidadAño(isi, 2008);
            var plan2023iq = TPI.Datos.Plan.GetPlanPorEspecialidadAño(iq, 2023);

            TPI.Entidades.Materia materia1 = new("Matematica Superior", 5, 50, plan2008isi);
            TPI.Entidades.Materia materia2 = new("Analisis Matematico", 7, 70, plan2023iq);
            TPI.Entidades.Materia materia3 = new("Bases de Datos", 7, 70, plan2008isi);
            TPI.Entidades.Materia materia4 = new("Quimica II", 7, 70, plan2023iq);

            AgregarMateria(materia1);
            AgregarMateria(materia2);
            AgregarMateria(materia3);
            AgregarMateria(materia4);
        }

        public static List<Entidades.Materia> GetMaterias()
        {
            return materias;
        }

        public static List<Entidades.Materia> GetMateriasPorPlan(Entidades.Plan plan)
            => materias.Where(x => x.Plan == plan).ToList();

        public static Entidades.Materia GetMateriaPorDescripcionYPlan(string descripcionMateriaSelecc, Entidades.Plan plan)
            => materias.FirstOrDefault(x => x.descMateria == descripcionMateriaSelecc && x.Plan == plan);
    }
}
