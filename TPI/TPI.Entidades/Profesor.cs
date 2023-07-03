using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Profesor : Persona
    {
        public int Legajo { get; private set; }

        public override string getTipo()
        {
            return "Profesor";
        }

        public Profesor(int dni, string nombre, string apellido, string contraseña, int legajo, string usuario) : base(dni, nombre, apellido, contraseña, usuario)
        {
            Legajo = legajo;
        }
    }
}
