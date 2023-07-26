//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Consola
//{
//    public class Alumno
//    {
//        public static void ShowMenuAltaAlumno()
//        {
//            Console.Clear();
//            Console.WriteLine("Alta de Alumno\n");
//            Console.Write("DNI: ");
//            int dni = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Legajo: ");
//            int legajo = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Nombre: ");
//            string nombre = Console.ReadLine();
//            Console.Write("Apellido: ");
//            string apellido = Console.ReadLine();
//            Console.Write("Nombre de Usuario: ");
//            string usuario = Console.ReadLine();
//            Console.Write("Contraseña: ");
//            string contraseña = Console.ReadLine();

//            TPI.Negocio.Alumno.CrearAlumno(dni, legajo, nombre, apellido, usuario, contraseña);

//            Console.WriteLine("\nAlumno/a Creado con Exito!");
//            Console.Write("Presione cualquier tecla ");
//            Console.ReadKey();
//        }
//        public static void ShowListadoAlumnos()
//        {
//            Console.Clear();
//            Console.WriteLine("Alumnos Registrados en el Sistema\n\n");
//            Console.WriteLine("Id\tDNI\t\tLegajo\t\tNombre\t\tApellido\tNombre de Usuario");
//            Console.WriteLine("--------------------------------------------------------------------------------------------");

//            List<TPI.Entidades.Usuario> alumnos = TPI.Negocio.Alumno.GetAllAlumnos();

//            foreach (TPI.Entidades.Alumno alumno in alumnos)
//            {
//                Console.WriteLine(alumno.Id + "\t" + alumno.Dni + "\t\t" + alumno.Legajo + "\t\t" + alumno.Nombre + "\t\t" + alumno.Apellido + "\t\t" + alumno.NombreUsuario);
//            }

//            Console.Write("\nPresione cualquier tecla ");
//            Console.ReadKey();
//        }
//    }
//}
