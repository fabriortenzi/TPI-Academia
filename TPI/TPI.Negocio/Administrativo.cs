using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Administrativo : Persona
    {
        public static void CrearAdministrativo(int dni, string nombre, string apellido, string usuario, string contraseña)
        {
            Entidades.Administrativo administrativoCreado = new(dni, nombre, apellido, usuario, contraseña);

            Datos.Persona.AgregarPersona(administrativoCreado);
        }

        public static List<Entidades.Persona> GetAllAdministrativos()
        {
            List<Entidades.Persona> administrativos = Datos.Administrativo.GetAllAdministrativos();
            return administrativos;
        }
    }
}
