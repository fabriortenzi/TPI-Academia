using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Comision
    {
        //public static Entidades.Comision GetComisionPorId(int idCom, int idEsp)
        //    => Datos.Comision.GetComisionPorId(idCom, idEsp);

        //public static Entidades.Comision GetComisionPorIdyDescEsp(string id_desc_esp)
        //{
        //    return Datos.Comision.GetComisionPorIdyDescEsp(id_desc_esp);
        //}

        public static List<Entidades.Comision> GetAll() 
        {
            return Datos.Comision.GetAll();
        }

        public static Entidades.Comision CrearComision(int idCom, Entidades.Especialidad especialidad)
            => new Entidades.Comision(idCom, especialidad);

        public static void AgregarComision(Entidades.Comision comision)
            => Datos.Comision.AgregarComision(comision);
    }
}
