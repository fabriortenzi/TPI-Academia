using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    internal class Alumno : Persona
    {
        public int Legajo { get; private set; }

        public Alumno(int dni, string nombre, string apellido, string contraseña, int legajo): base(dni, nombre, apellido, contraseña)
        {
            Legajo = legajo;
        }
    }
}
