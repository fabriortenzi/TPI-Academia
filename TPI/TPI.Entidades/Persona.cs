using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public abstract class Persona
    {
        public int Dni { get; private set; }        

        public string Contraseña { get; private set; }

        public string Usuario { get; private set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public abstract string getTipo();

        public Persona(int dni, string nombre, string apellido, string contraseña, string usuario)
        {
            Dni = dni;
            Contraseña = contraseña;
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
        }
    }
}
