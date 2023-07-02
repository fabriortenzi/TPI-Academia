using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    internal abstract class Persona
    {
        public int Dni { get; private set; }        

        private string Contraseña;

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public Persona(int dni, string nombre, string apellido, string contraseña)
        {
            Dni = dni;
            Contraseña = contraseña;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
