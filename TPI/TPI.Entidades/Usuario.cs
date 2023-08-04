using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Usuario
    {
        private static int UltimoLegajo = 1;

        public int Legajo { get; private set; }  
        
        public string Contraseña { get; set; }

        public Persona Persona { get; private set; }

        public TipoDeUsuario TipoDeUsuario { get; private set; }

        public Usuario(string contraseña, Persona persona, TipoDeUsuario tipoDeUsuario)
        {
            Legajo = UltimoLegajo++;
            Contraseña = contraseña;
            Persona = persona;
            TipoDeUsuario = tipoDeUsuario;
        }
    }
}
