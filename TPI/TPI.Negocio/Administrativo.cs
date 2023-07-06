using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Administrativo : Usuario
    {
        public static void CrearAdministrativo(int dni, string nombre, string apellido, string usuario, string contraseña)
        {
            Entidades.Administrativo administrativoCreado = new(dni, nombre, apellido, usuario, contraseña);

            Datos.Usuario.AgregarUsuario(administrativoCreado);
        }

        public static List<Entidades.Usuario> GetAllAdministrativos()
        {
            List<Entidades.Usuario> administrativos = Datos.Administrativo.GetAllAdministrativos();
            return administrativos;
        }
    }
}
