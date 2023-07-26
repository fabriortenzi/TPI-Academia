using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TPI.Datos;
using TPI.Entidades;

namespace TPI.Negocio
{
    public class Usuario
    {
        public static void CrearUsuario(string contraseña, Entidades.Persona persona, Entidades.TipoDeUsuario tipoDeUsuario)
        {
            Entidades.Usuario usuario = new(contraseña, persona, tipoDeUsuario);
        }
        
        public static Entidades.Usuario GetUsuarioPorNombreUsuarioYContraseña(string nombreUsuario, string contraseña)
        {
            Entidades.Usuario usuario = TPI.Datos.Usuario.GetUsuarioPorNombreUsuarioYContraseña(nombreUsuario, contraseña);
            return usuario;
        }

        public static List<Entidades.Usuario> GetAllUsuarios()
        {
            List<Entidades.Usuario> usuarios = TPI.Datos.Usuario.GetAllUsuarios();
            return usuarios;
        }

        public static Entidades.Usuario GetUsuarioPorNombreApellido(string nombre, string apellido)
        {
            Entidades.Usuario usuario = Datos.Usuario.GetUsuarioPorNombreApellido(nombre, apellido);
            return usuario;
        }

        public static List<TPI.Entidades.Usuario> GetAllAlumnos()
        {
            List<TPI.Entidades.Usuario> alumnos = TPI.Datos.Alumno.GetAllAlumnos();
            return alumnos;
        }

        public static List<Entidades.Usuario> GetAllProfesores()
        {
            List<Entidades.Usuario> profesores = Datos.Profesor.GetAllProfesores();
            return profesores;
        }

        public static List<Entidades.Usuario> GetAllAdministrativos()
        {
            List<Entidades.Usuario> administrativos = Datos.Administrativo.GetAllAdministrativos();
            return administrativos;
        }
    }
}
