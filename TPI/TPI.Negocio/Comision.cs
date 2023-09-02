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

        public static Entidades.Comisiones GetComisionPorIdyDescEsp(string id_desc_esp)
        {
            return Datos.Comision.GetComisionPorIdyDescEsp(id_desc_esp);
        }

        public static List<Entidades.Comisiones> GetAll() 
        {
            return Datos.Comision.GetAll();

        }

    }

   

}
