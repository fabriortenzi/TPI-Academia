using System;
using TPI.Negocio;
using TPI.Entidades;
using System.Runtime.Intrinsics.Arm;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TPI.Negocio.Persona personaNegocio = new();

            TPI.Entidades.Persona personaIngresada = personaNegocio.getPersonaPorUsuarioYContraseña("juangomez", "clave1");

            if (personaIngresada != null)
            {
                switch (personaIngresada.getTipo())
                {
                    case "Alumno":
                        // TODO
                        Console.WriteLine("Bienvenido Alumno/a");
                        break;
                    case "Profesor":
                        // TODO
                        Console.WriteLine("Bienvenido Profesor/a");
                        break;
                    case "Administrativo":
                        showMenuAdministrativo();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nombre de Usuario o Contrseña incorrectos");
            }
        }

        private static void showMenuAdministrativo()
        {
            Console.Clear();
            Console.WriteLine("Menu Administrativo/a");
            Console.WriteLine("\n1- Crear Persona (Alumno, Profesor o Administrativo)");
            Console.WriteLine("0- Salir del Sistema");

            Console.Write("\n\nOpcion: ");
            ConsoleKeyInfo opcion = Console.ReadKey();

            while (opcion.Key != ConsoleKey.D1 && opcion.Key != ConsoleKey.D0)
            {
                Console.WriteLine();
                Console.Write("Vuelva a ingresar la opcion: ");
                opcion = Console.ReadKey();
            }

            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    showMenuAltaPersona();
                    break;
            }
        }

        private static void showMenuAltaPersona()
        {
            Console.Clear();
            Console.WriteLine("Alta de Persona");
            Console.WriteLine("\n1- Crear Alumno");
            Console.WriteLine("\n2- Crear Profesor");
            Console.WriteLine("\n3- Crear Administrativo");
            Console.WriteLine("0- Salir");

            Console.Write("\n\nOpcion: ");
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
                    showMenuAltaAlumno();
                    break;
            }
        }

        private static void showMenuAltaAlumno()
        {
            Console.Clear();
            Console.WriteLine("Alta de Alumno\n");
            Console.Write("DNI: ");
            Console.WriteLine("Legajo: ");
            Console.WriteLine("Nombre: ");
            Console.WriteLine("Apellido: ");
            Console.WriteLine("Nombre de Usuario: ");
            Console.WriteLine("Contraseña: ");
        }
    }
}
