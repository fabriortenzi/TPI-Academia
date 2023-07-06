using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Profesor : Usuario
    {
        public static void CrearProfesor(int dni, int legajo, string nombre, string apellido,string usuario, string contraseña)
        {
            Entidades.Profesor profesorCreado = new(dni, legajo, nombre, apellido, usuario, contraseña);

            Datos.Usuario.AgregarUsuario(profesorCreado);
        }

        public static List<Entidades.Usuario> GetAllProfesores()
        {
            List<Entidades.Usuario> profesores = Datos.Profesor.GetAllProfesores();
            return profesores;
        }
    }
}
