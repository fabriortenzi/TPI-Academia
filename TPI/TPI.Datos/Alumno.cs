using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Alumno : Usuario
    {
        public static List<TPI.Entidades.Usuario> GetAllAlumnos()
        {
            var alumnos = listaUsuarios.Where(x => x.getTipo() == "Alumno").ToList();
            return alumnos;
        }
    }
}
