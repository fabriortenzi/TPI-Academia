using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Persona
    {
        [Key]
        public int Dni { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Telefono { get; set; }

        public Persona() { }

        public Persona(int dni, string nombre, string apellido, string direccion, DateTime fechaNacimiento, string telefono)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
