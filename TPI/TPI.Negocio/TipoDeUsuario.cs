using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class TipoDeUsuario
    {
        public static List<Entidades.TipoDeUsuario> GetAllTiposDeUsuario()
            => Datos.TipoDeUsuario.GetAllTiposDeUsuario();

        public static Entidades.TipoDeUsuario GetTipoUsuarioPorDecsripcion(string descripcion)
            => Datos.TipoDeUsuario.GetTipoUsuarioPorDescripcion(descripcion);
    }
}
