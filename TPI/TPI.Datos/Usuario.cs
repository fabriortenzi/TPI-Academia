﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Usuario
    {
        private static List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();
        
        public static void AgregarUsuario(Entidades.Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public static void InicializarListaUsarios()
        {
            Entidades.TipoDeUsuario tipoAlumno = Datos.TipoDeUsuario.GetTipoAlumno();
            Entidades.TipoDeUsuario tipoProfesor = Datos.TipoDeUsuario.GetTipoProfesor();
            Entidades.TipoDeUsuario tipoAdmin = Datos.TipoDeUsuario.GetTipoAdmin();

            var persona1 = Datos.Persona.GetPersonaPorDni(43127777);
            var persona2 = Datos.Persona.GetPersonaPorDni(43127778);
            var persona3 = Datos.Persona.GetPersonaPorDni(43127779);

            Entidades.Usuario alumno1 = new("clave", persona1, tipoAlumno);
            Entidades.Usuario profesor1 = new("clave", persona2, tipoProfesor);
            Entidades.Usuario administrativo1 = new("clave", persona3, tipoAdmin);

            AgregarUsuario(alumno1);
            AgregarUsuario(profesor1);
            AgregarUsuario(administrativo1);
        }        

        public static Entidades.Usuario GetUsuarioPorLegajoYContraseña(int legajo, string contraseña) => 
            usuarios.FirstOrDefault(x => x.Legajo == legajo && x.Contraseña == contraseña);

        public static List<Entidades.Usuario> GetAllUsuarios() => usuarios;
    }
}
