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
        private static List<Entidades.Usuario> listaUsuarios = new List<Entidades.Usuario>();
        
        public static void AgregarUsuario(Entidades.Usuario usuario)
        {
            listaUsuarios.Add(usuario);
        }

        public static void InicializarListaUsarios()
        {
            Entidades.TipoDeUsuario tipoAlumno = Datos.TipoDeUsuario.GetTipoAlumno();
            Entidades.TipoDeUsuario tipoProfesor = Datos.TipoDeUsuario.GetTipoProfesor();
            Entidades.TipoDeUsuario tipoAdmin = Datos.TipoDeUsuario.GetTipoAdmin();

            Entidades.Usuario alumno1 = new("clave", , tipoAlumno);
            Entidades.Usuario profesor1 = new("clave", , tipoProfesor);
            Entidades.Usuario administrativo1 = new("clave", , tipoAdmin);

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
