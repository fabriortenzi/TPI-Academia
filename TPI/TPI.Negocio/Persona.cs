using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Persona
    {
        public static Entidades.Persona CrearPersona(int dni, string nombre, string apellido, string direccion, DateTime fechaNacimiento, string telefono)
        {
            Entidades.Persona persona = new(dni, nombre, apellido, direccion, fechaNacimiento, telefono);
            return persona;
        }
    }
}
