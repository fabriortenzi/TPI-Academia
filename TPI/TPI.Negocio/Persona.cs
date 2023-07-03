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
        private Datos.Persona personaDatos = new();

        public Entidades.Persona getPersonaPorUsuarioYContraseña(string usuario, string contraseña)
        {
            Entidades.Persona persona = personaDatos.getPersonaPorUsuarioYContraseñaDatos(usuario, contraseña);
            return persona;
        }
    }
}
