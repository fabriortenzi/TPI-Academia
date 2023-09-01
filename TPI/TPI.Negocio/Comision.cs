using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Comision
    {
        public static Entidades.Comisiones GetComisionPorId(int idCom, int idEsp)
            => Datos.Comision.GetComisionPorId(idCom, idEsp);
    }
}
