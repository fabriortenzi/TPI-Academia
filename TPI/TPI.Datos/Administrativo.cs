using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Administrativo : Persona
    {
        public static List<TPI.Entidades.Persona> GetAllAdministrativos()
        {
            var administrativos = listaPersonas.Where(x => x.getTipo() == "Administrativo").ToList();
            return administrativos;
        }
    }
}
