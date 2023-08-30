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

        public static void CambiarContraseña(Entidades.Usuario usuario, string nuevaCont)
        {
            TPI.Datos.Usuario.CambiarContraseña(usuario, nuevaCont);
        }

        public static void AsignarPlanAUsuario(Entidades.Plan Plan, Entidades.Usuario Usuario)
        {
            Datos.Usuario.AsignarPlanAUsuario(Plan, Usuario);
        }
    }
}
