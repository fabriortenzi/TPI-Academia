using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Persona
    {
        public static void ShowMenuAltaPersona()
        {
            Console.Clear();
            Console.WriteLine("Alta de Persona");
            Console.WriteLine("\n1- Crear Alumno");
            Console.WriteLine("2- Crear Profesor");
            Console.WriteLine("3- Crear Administrativo");
            Console.WriteLine("0- Salir");

            Console.Write("\nOpcion: ");
            ConsoleKeyInfo opcion = Console.ReadKey();

            while (opcion.Key != ConsoleKey.D1 && opcion.Key != ConsoleKey.D2 && opcion.Key != ConsoleKey.D3 && opcion.Key != ConsoleKey.D0)
            {
                Console.WriteLine();
                Console.Write("Vuelva a ingresar la opcion: ");
                opcion = Console.ReadKey();
            }

            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    Alumno.ShowMenuAltaAlumno();
                    break;
                case ConsoleKey.D2:
                    Profesor.ShowMenuAltaProfesor();
                    break;
                case ConsoleKey.D3:
                    Administrativo.ShowMenuAltaAdministrativo();
                    break;
            }
        }

        public static void ShowMenuListadoPersonas()
        {
            Console.Clear();
            Console.WriteLine("Listado de Personas\n");
            Console.WriteLine("1- Listado de Alumnos");
            Console.WriteLine("2- Listado de Profesores");
            Console.WriteLine("3- Listado de Administrativos");
            Console.WriteLine("0- Salir");

            Console.Write("\nOpcion: ");
            ConsoleKeyInfo opcion = Console.ReadKey();

            while (opcion.Key != ConsoleKey.D1 && opcion.Key != ConsoleKey.D2 && opcion.Key != ConsoleKey.D3 && opcion.Key != ConsoleKey.D0)
            {
                Console.WriteLine();
                Console.Write("Vuelva a ingresar la opcion: ");
                opcion = Console.ReadKey();
            }

            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    Alumno.ShowListadoAlumnos();
                    break;
                case ConsoleKey.D2:
                    Profesor.ShowListadoProfesores();
                    break;
                case ConsoleKey.D3:
                    Administrativo.ShowListadoAdministrativos();
                    break;
            }
        }
    }
}
