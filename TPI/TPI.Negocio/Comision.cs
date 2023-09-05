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

        public static Entidades.Comisiones CrearComision(int idCom, Entidades.Especialidad especialidad)
            => new Entidades.Comisiones(idCom, especialidad);

        public static void AgregarComision(Entidades.Comisiones comision)
            => Datos.Comision.AgregarComision(comision);
    }
}
