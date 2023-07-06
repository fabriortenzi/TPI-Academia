using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Alumno : Persona
    {
        public static List<TPI.Entidades.Persona> GetAllAlumnos()
        {
            var alumnos = listaPersonas.Where(x => x.getTipo() == "Alumno").ToList();
            return alumnos;
        }
    }
}
