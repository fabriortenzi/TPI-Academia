using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Administrativo : Usuario
    {
        public override string getTipo()
        {
            return "Administrativo";
        }
        public Administrativo(int dni, string nombre, string apellido, string contraseña, string usuario) : base(dni, nombre, apellido, contraseña, usuario) { }
    }
}
