using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class ModuloUsuario
    {
        public static Entidades.ModuloUsuario GetModuloUsuario(Entidades.Modulo modulo, Entidades.TipoDeUsuario tipoDeUsuario)
            => Datos.ModuloUsuario.GetModuloUsuario(modulo, tipoDeUsuario);
    }
}
