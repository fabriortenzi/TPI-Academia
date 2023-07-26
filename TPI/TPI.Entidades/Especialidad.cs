using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
   public class Especialidad
    {
        public int idEspec { get; private set; }

        public string descEspec { get; private set; }


        public Especialidad (int id_espec , string desc_espec) {

            idEspec = id_espec;
            descEspec = desc_espec;
        }

    }
}
