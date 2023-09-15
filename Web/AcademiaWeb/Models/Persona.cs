using System.ComponentModel.DataAnnotations;
using System;

namespace AcademiaWeb.Models
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
    }
}
