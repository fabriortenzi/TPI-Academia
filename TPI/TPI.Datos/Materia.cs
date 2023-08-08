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
            TPI.Entidades.Materia materia1 = new("Matematica Superior", 5, 50);
            TPI.Entidades.Materia materia2 = new("Analisis Matematico", 7, 70);

            AgregarMateria(materia1);
            AgregarMateria(materia2);
        }

        public static List<Entidades.Materia> GetMaterias()
        {
            return materias;
        }
    }
}
