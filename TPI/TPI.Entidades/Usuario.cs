using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Usuario
    {
        private static int UltimoLegajo = 1;

        [Key]
        public int Legajo { get; private set; }  
        
        public string Contraseña { get; set; }

        public Persona Persona { get; private set; }

        public TipoDeUsuario TipoDeUsuario { get; private set; }

        public Plan? Plan { get; set; }

        public Usuario() { }

        public Usuario(string contraseña, Persona persona, TipoDeUsuario tipoDeUsuario)
        {
            Legajo = UltimoLegajo++;
            Contraseña = contraseña;
            Persona = persona;
            TipoDeUsuario = tipoDeUsuario;
        }
    }
}
