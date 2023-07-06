using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Administrativo
    {
        public static void ShowMenuAdministrativo()
        {
            ConsoleKeyInfo opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Administrativo/a");
                Console.WriteLine("\n1- Crear Usuario (Alumno, Profesor o Administrativo)");
                Console.WriteLine("2- Lista de Usuarios");
                Console.WriteLine("0- Salir del Sistema");

                Console.Write("\nOpcion: ");
                opcion = Console.ReadKey();

                while (opcion.Key != ConsoleKey.D1 && opcion.Key != ConsoleKey.D2 && opcion.Key != ConsoleKey.D0)
                {
                    Console.WriteLine();
                    Console.Write("Vuelva a ingresar la opcion: ");
                    opcion = Console.ReadKey();
                }

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Usuario.ShowMenuAltaUsuario();
                        break;
                    case ConsoleKey.D2:
                        Usuario.ShowMenuListadoUsuarios();
                        break;
                }

            } while (opcion.Key != ConsoleKey.D0);
        }
        
        public static void ShowMenuAltaAdministrativo()
        {
            Console.Clear();
            Console.WriteLine("Alta de Administrativo/a\n");
            Console.Write("DNI: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Nombre de Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string contraseña = Console.ReadLine();

            TPI.Negocio.Administrativo.CrearAdministrativo(dni, nombre, apellido, usuario, contraseña);

            Console.WriteLine("\nAdministrativo/a Creado con Exito!");
            Console.Write("Presione cualquier tecla ");
            Console.ReadKey();
        }

        public static void ShowListadoAdministrativos()
        {
            Console.Clear();
            Console.WriteLine("Administrativos Registrados en el Sistema\n\n");
            Console.WriteLine("Id\tDNI\t\tNombre\t\tApellido\tNombre de Usuario");
            Console.WriteLine("---------------------------------------------------------------------------");

            List<TPI.Entidades.Usuario> administrativos = TPI.Negocio.Administrativo.GetAllAdministrativos();

            foreach (TPI.Entidades.Administrativo administrativo in administrativos)
            {
                Console.WriteLine(administrativo.Id + "\t" + administrativo.Dni + "\t\t" + administrativo.Nombre + "\t\t" + administrativo.Apellido + "\t\t" + administrativo.NombreUsuario);
            }

            Console.Write("\nPresione cualquier tecla ");
            Console.ReadKey();
        }        
    }
}
