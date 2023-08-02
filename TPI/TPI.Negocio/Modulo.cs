using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Modulo
    {
        public static Entidades.Modulo CrearModulo(string descripcion, string ejecuta)
            => new Entidades.Modulo(descripcion, ejecuta);

        public static void AgregarModulo(Entidades.Modulo modulo)
        {
            Datos.Modulo.AgregarModulo(modulo);
        }

        public static Entidades.Modulo GetModuloPersona()
            => Datos.Modulo.GetModuloPersona();
    }
}
