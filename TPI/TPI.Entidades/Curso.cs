using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Curso
    {
        public Materia Materia { get; private set; }

        public int Año { get; private set; }

        public int Cupo { get; private set; }

        public Curso(Materia materia, int año, int cupo)
        {
            Materia = materia;
            Año = año;
            Cupo = cupo;
        }
    }
}
