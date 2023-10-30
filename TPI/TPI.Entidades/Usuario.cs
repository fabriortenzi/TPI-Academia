using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Usuario
    {
        [Key]
        public int Legajo { get; }  
        
        public string Contraseña { get; set; }

        public Persona Persona { get; set; }

        public TipoDeUsuario TipoDeUsuario { get; set; }

        public Plan? Plan { get; set; }

        [NotMapped]
        public string NombreCompleto => $"{Persona.Apellido} {Persona.Nombre}";

        public Usuario() { }

        public Usuario(string contraseña, Persona persona, TipoDeUsuario tipoDeUsuario)
        {
            Contraseña = contraseña;
            Persona = persona;
            TipoDeUsuario = tipoDeUsuario;
        }

        public override string ToString()
        {
            return $"Legajo: {Legajo} - {NombreCompleto}";
        }
    }
}
