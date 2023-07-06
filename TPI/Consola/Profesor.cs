using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Profesor
    {
        public static void ShowMenuAltaProfesor()
        {
            Console.Clear();
            Console.WriteLine("Alta de Profesor/a\n");
            Console.Write("DNI: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            Console.Write("Legajo: ");
            int legajo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Nombre de Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string contraseña = Console.ReadLine();

            TPI.Negocio.Profesor.CrearProfesor(dni, legajo, nombre, apellido, usuario, contraseña);

            Console.WriteLine("\nProfesor/a Creado con Exito!");
            Console.Write("Presione cualquier tecla ");
            Console.ReadKey();
        }

        public static void ShowListadoProfesores()
        {
            Console.Clear();
            Console.WriteLine("Profesores Registrados en el Sistema\n\n");
            Console.WriteLine("Id\tDNI\t\tLegajo\t\tNombre\t\tApellido\tNombre de Usuario");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

            List<TPI.Entidades.Usuario> profesores = TPI.Negocio.Profesor.GetAllProfesores();

            foreach (TPI.Entidades.Profesor profesor in profesores)
            {
                Console.WriteLine(profesor.Id + "\t" + profesor.Dni + "\t\t" + profesor.Legajo + "\t\t" + profesor.Nombre + "\t\t" + profesor.Apellido + "\t\t" + profesor.NombreUsuario);
            }

            Console.Write("\nPresione cualquier tecla ");
            Console.ReadKey();
        }
    }
}
