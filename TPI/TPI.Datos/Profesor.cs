using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Profesor : Usuario
    {
        public static List<TPI.Entidades.Usuario> GetAllProfesores()
        {
            var profesores = listaUsuarios.Where(x => x.getTipo() == "Profesor").ToList();
            return profesores;
        }
    }
}
