using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    internal class Administrativo : Persona
    {
        public Administrativo(int dni, string nombre, string apellido, string contraseña) : base(dni, nombre, apellido, contraseña) { }
    }
}
