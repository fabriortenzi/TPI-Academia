using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class ModuloUsuario
    {
        public Modulo Modulo { get; private set; }

        public TipoDeUsuario TipoDeUsuario { get; private set; }

        public bool Alta { get; private set; }

        public bool Baja { get; private set; }

        public bool Modificacion { get; private set; }

        public bool Consulta { get; private set; }

        public ModuloUsuario(Modulo modulo, TipoDeUsuario tipoDeUsuario, bool alta, bool baja, bool mofificacion, bool consulta)
        {
            Modulo = modulo;
            TipoDeUsuario = tipoDeUsuario;
            Alta = alta;
            Baja = baja;
            Modificacion = mofificacion;
            Consulta = consulta;
        }
    }
}
