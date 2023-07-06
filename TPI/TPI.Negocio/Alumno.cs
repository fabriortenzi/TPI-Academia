using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;
using TPI.Datos;

namespace TPI.Negocio
{
    public class Alumno : Usuario 
    {
        public static void CrearAlumno(int dni, int legajo, string nombre, string apellido, string usuario, string contraseña)
        {
            Entidades.Alumno alumnoCreado = new(dni, legajo, nombre, apellido, usuario, contraseña);

            Datos.Usuario.AgregarUsuario(alumnoCreado);
        }

        public static List<TPI.Entidades.Usuario> GetAllAlumnos()
        {
            List<TPI.Entidades.Usuario> alumnos = TPI.Datos.Alumno.GetAllAlumnos();
            return alumnos;
        }
    }
}
