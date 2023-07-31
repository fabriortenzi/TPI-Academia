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
        public static Entidades.Usuario CrearUsuario(string contraseña, Entidades.Persona persona, Entidades.TipoDeUsuario tipoDeUsuario)
            => new(contraseña, persona, tipoDeUsuario);

        public static void AgregarUsuario(Entidades.Usuario usuario)
        {
            Datos.Usuario.AgregarUsuario(usuario);
        }
        
        public static Entidades.Usuario GetUsuarioPorLegajoYContraseña(int legajo, string contraseña) => 
            TPI.Datos.Usuario.GetUsuarioPorLegajoYContraseña(legajo, contraseña);

        public static List<Entidades.Usuario> GetAllUsuarios() => 
            TPI.Datos.Usuario.GetAllUsuarios();

        //public static List<TPI.Entidades.Usuario> GetAllAlumnos()
        //{
        //    List<TPI.Entidades.Usuario> alumnos = TPI.Datos.Alumno.GetAllAlumnos();
        //    return alumnos;
        //}

        //public static List<Entidades.Usuario> GetAllProfesores()
        //{
        //    List<Entidades.Usuario> profesores = Datos.Profesor.GetAllProfesores();
        //    return profesores;
        //}

        //public static List<Entidades.Usuario> GetAllAdministrativos()
        //{
        //    List<Entidades.Usuario> administrativos = Datos.Administrativo.GetAllAdministrativos();
        //    return administrativos;
        //}
    }
}
