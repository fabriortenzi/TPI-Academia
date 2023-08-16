using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Modulo
    {
        public static int UltimoId = 1;

        [Key]
        public int Id { get; private set; }

        public string Descripcion { get; set; }

        public string? Ejecuta { get; set; }

        public Modulo(string descripcion, string ejecuta)
        {
            Id = UltimoId++;
            Descripcion = descripcion;
            Ejecuta = ejecuta;
        }
    }
}
