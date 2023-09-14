using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class TipoDeUsuario
    {
        public int Id { get; }

        public string Descripcion { get; set; }

        public TipoDeUsuario(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}
