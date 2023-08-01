using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Materia
    {
        public static Entidades.Materia CrearMateria(string descMat,int hor_sem,int hor_tot)
        {
            Entidades.Materia materia = new(descMat, hor_sem, hor_tot);

            return materia;
        }

        public static void AgregaMateria(TPI.Entidades.Materia materia)
        {
            TPI.Datos.Materia.AgregarMateria(materia);
        }
    }
}
