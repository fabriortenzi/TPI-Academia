using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    class Planes
    {

        private static List<Entidades.Planes> planes = new List<Entidades.Planes>();

        public static void AgregarEspecialidades(Entidades.Planes plan)
        {
            planes.Add(plan);
        }

        public static void InicializarListaEspecialidades()
        {
            Entidades.Planes plan1 = new(2008, "Plan 2008");

            Entidades.Planes plan2 = new(2023, "Plan 2023");


            AgregarEspecialidades(plan1);
            AgregarEspecialidades(plan2);
 

        }
    }
}
