using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Comision
    {
        public static Entidades.Comision BuscarComisionPorNroEspecialidad(int nro_com,Entidades.Especialidad esp)
        {
            return TPI.Datos.Comision.GetAll().First(x => x.NroComision == nro_com && x.Especialidad.Id == esp.Id);
        }

        public static List<Entidades.Comision> BuscarComisionesPorEspecialidad(Entidades.Especialidad esp)
        {
            return TPI.Datos.Comision.GetAll().Where(x => x.Especialidad.Id == esp.Id).ToList();
        }
        public static Entidades.Comision Crear(int id, Entidades.Especialidad especialidad)
        { return new Entidades.Comision(id, especialidad); }
        
        public static Entidades.Comision GetOne(int id)
        {
            return Datos.Comision.GetOne(id);
        }

        public static List<Entidades.Comision> GetAll()
        {
            return Datos.Comision.GetAll();
        }

        public static void Agregar(Entidades.Comision comision)
            => Datos.Comision.AgregarComision(comision);
        
        public static void Eliminar(Entidades.Comision comision)
           => Datos.Comision.Eliminar(comision);
        public static void Cambiar(Entidades.Comision comision, int nroComision, Entidades.Especialidad especialidad)
           => Datos.Comision.Cambiar(comision, nroComision, especialidad);

    }
}
