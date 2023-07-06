using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;
using TPI.Datos;

namespace TPI.Negocio
{
    public class Alumno : Persona 
    {
        public static void CrearAlumno(int dni, int legajo, string nombre, string apellido, string usuario, string contraseña)
        {
            Entidades.Alumno alumnoCreado = new(dni, legajo, nombre, apellido, usuario, contraseña);

            Datos.Persona.AgregarPersona(alumnoCreado);
        }

        public static List<TPI.Entidades.Persona> GetAllAlumnos()
        {
            List<TPI.Entidades.Persona> alumnos = TPI.Datos.Alumno.GetAllAlumnos();
            return alumnos;
        }
    }
}
