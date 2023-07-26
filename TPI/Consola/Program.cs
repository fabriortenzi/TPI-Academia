using System;
using TPI.Negocio;
using TPI.Entidades;
using System.Runtime.Intrinsics.Arm;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Inicializar Lista de Usuarios en la Capa Datos
            //TPI.Datos.Usuario.InicializarLista();

            //string usuario;
            //string contraseña;
            //Console.Clear();
            //Console.WriteLine("Bienvenido al Sistema!");
            //Console.WriteLine("Digite su Informacion de Ingreso\n");
            //Console.Write("Usuario: ");
            //usuario = Console.ReadLine();
            //Console.Write("Contraseña: ");
            //contraseña = Console.ReadLine();

            //TPI.Entidades.Usuario usuarioIngresad = TPI.Negocio.Usuario.GetUsuarioPorNombreUsuarioYContraseña(usuario, contraseña);

            //if (usuarioIngresad != null)
            //{
            //    switch (usuarioIngresad.getTipo())
            //    {
            //        case "Alumno":
            //            // TODO
            //            Console.WriteLine("Bienvenido Alumno/a");
            //            break;
            //        case "Profesor":
            //            // TODO
            //            Console.WriteLine("Bienvenido Profesor/a");
            //            break;
            //        case "Administrativo":
            //            Administrativo.ShowMenuAdministrativo();
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Nombre de Usuario o Contrseña incorrectos");
            //}
        }
    }
}
