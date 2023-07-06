using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Datos;

namespace TPI.Negocio
{
    public class Persona
    {
        public static Entidades.Persona GetPersonaPorUsuarioYContraseña(string usuario, string contraseña)
        {
            Entidades.Persona persona = TPI.Datos.Persona.GetPersonaPorUsuarioYContraseña(usuario, contraseña);
            return persona;
        }
    }
}
