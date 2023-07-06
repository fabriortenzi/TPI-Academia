using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Profesor : Persona
    {
        public static List<TPI.Entidades.Persona> GetAllProfesores()
        {
            var profesores = listaPersonas.Where(x => x.getTipo() == "Profesor").ToList();
            return profesores;
        }
    }
}
