using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace AcademiaWeb.Models
{
    public class Usuario
    {
        [Key]
        public int Legajo { get; set; }

        public string Contraseña { get; set; }

        public Persona Persona { get; set; }

        public TipoDeUsuario TipoDeUsuario { get; set; }

        public Plan? Plan { get; set; }
    }
}
