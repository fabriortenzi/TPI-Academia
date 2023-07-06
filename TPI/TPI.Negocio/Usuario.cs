using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Datos;

namespace TPI.Negocio
{
    public class Usuario
    {
        public static Entidades.Usuario GetUsuarioPorNombreUsuarioYContraseña(string nombreUsuario, string contraseña)
        {
            Entidades.Usuario usuario = TPI.Datos.Usuario.GetUsuarioPorNombreUsuarioYContraseña(nombreUsuario, contraseña);
            return usuario;
        }
    }
}
