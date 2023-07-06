using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Profesor : Usuario
    {
        public int Legajo { get; private set; }

        public override string getTipo()
        {
            return "Profesor";
        }

        public Profesor(int dni, int legajo, string nombre, string apellido, string usuario, string contraseña) : base(dni, nombre, apellido, usuario, contraseña)
        {
            Legajo = legajo;
        }
    }
}
