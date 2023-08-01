using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Materia
    {
       private static int UlitmoId = 1;

        public int idMateria { get; private set; }

        public string descMateria { get; private set; }

        public int horaSem { get; private set; }

        public int horaTot { get; private set; }

        public Materia (string desc,int hora_sem,int hora_tot)
        {
            idMateria = UlitmoId++ ;

            descMateria = desc;

            horaSem = hora_sem;

            horaTot = hora_tot;
        }
    }
}
