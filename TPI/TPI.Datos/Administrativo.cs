using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Administrativo : Usuario
    {
        public static List<TPI.Entidades.Usuario> GetAllAdministrativos()
        {
            var administrativos = listaUsuarios.Where(x => x.getTipo() == "Administrativo").ToList();
            return administrativos;
        }
    }
}
