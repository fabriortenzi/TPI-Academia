using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    internal class Modulo
    {
        public int Id { get; private set; }

        public string Descripcion { get; set; }

        public string Ejecuta { get; set; }

        public Modulo(int id, string descripcion, string ejecuta)
        {
            Id = id;
            Descripcion = descripcion;
            Ejecuta = ejecuta;
        }
    }
}
