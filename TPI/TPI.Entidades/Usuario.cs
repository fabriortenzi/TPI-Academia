using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
<<<<<<< HEAD:TPI/TPI.Entidades/Persona.cs
    public abstract class Persona
=======
    public abstract class Usuario
>>>>>>> Administrativo:TPI/TPI.Entidades/Usuario.cs
    {
        private static int UltimoId = 1;

<<<<<<< HEAD:TPI/TPI.Entidades/Persona.cs
        public string Contraseña { get; private set; }

        public string Usuario { get; private set; }
=======
        public int Id { get; private set; }
        
        public int Dni { get; private set; }        
>>>>>>> Administrativo:TPI/TPI.Entidades/Usuario.cs

        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
        
        public string NombreUsuario { get; private set; }
        
        public string Contraseña { get; private set; }

        public abstract string getTipo();

<<<<<<< HEAD:TPI/TPI.Entidades/Persona.cs
        public Persona(int dni, string nombre, string apellido, string contraseña, string usuario)
=======
        public Usuario(int dni, string nombre, string apellido, string usuario, string contraseña)
>>>>>>> Administrativo:TPI/TPI.Entidades/Usuario.cs
        {
            Id = UltimoId++;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
<<<<<<< HEAD:TPI/TPI.Entidades/Persona.cs
            Usuario = usuario;
=======
            NombreUsuario = usuario;
            Contraseña = contraseña;
>>>>>>> Administrativo:TPI/TPI.Entidades/Usuario.cs
        }
    }
}
