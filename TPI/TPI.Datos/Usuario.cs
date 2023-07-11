using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Usuario
    {
        private static Entidades.Alumno alumno1 = new(123, 47, "Fabri", "Ortenzi", "juangomez", "clave");
        private static Entidades.Profesor profesor1 = new(12, 47, "Maria", "Gutierrez", "marigutierrez", "clave");
        private static Entidades.Administrativo administrativo1 = new(13, "Juan", "Gomez", "fabriortenzi", "clave");

        static protected List<Entidades.Usuario> listaUsuarios = new List<Entidades.Usuario>();
        
        public static void AgregarUsuario(Entidades.Usuario usuario)
        {
            listaUsuarios.Add(usuario);
        }

        public static void InicializarLista()
        {
            AgregarUsuario(alumno1);
            AgregarUsuario(profesor1);
            AgregarUsuario(administrativo1);
        }        

        public static Entidades.Usuario GetUsuarioPorNombreUsuarioYContraseña(string nombreUsuario, string contraseña)
        {
            var usuario = listaUsuarios.FirstOrDefault(x => x.NombreUsuario == nombreUsuario && x.Contraseña == contraseña);
            return usuario;
        }

        public static List<Entidades.Usuario> GetAllUsuarios() => listaUsuarios;

        public static Entidades.Usuario GetUsuarioPorNombreApellido(string nombre, string apellido) =>
            listaUsuarios.FirstOrDefault(x => x.Nombre.ToLower() == nombre.ToLower() && x.Apellido.ToLower() == apellido.ToLower());
    }
}
