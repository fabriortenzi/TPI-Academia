using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public abstract class Usuario
    {
        private static int UltimoId = 1;

        public int Id { get; private set; }
        
        public int Dni { get; private set; }        

        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
        
        public string NombreUsuario { get; private set; }
        
        public string Contraseña { get; private set; }

        public abstract string getTipo();

        public Usuario(int dni, string nombre, string apellido, string usuario, string contraseña)
        {
            Id = UltimoId++;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = usuario;
            Contraseña = contraseña;
        }
    }
}
