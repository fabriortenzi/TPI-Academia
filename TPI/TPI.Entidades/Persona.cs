using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Persona
    {
        [Key]
        public int Dni { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public Persona(int dni, string nombre, string apellido, string direccion, DateTime fechaNacimiento, string telefono)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }
    }
}
