using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Comisiones
    {
        public int idCom { get; private set; }

        public Comisiones (int id_com)
        {
            idCom = id_com; 
        }
    }
}
