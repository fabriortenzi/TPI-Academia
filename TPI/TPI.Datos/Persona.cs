using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Persona
    {
        private static Entidades.Alumno alumno1 = new(123, 47, "Fabri", "Ortenzi", "fabriortenzi", "clave");
        private static Entidades.Profesor profesor1 = new(12, 47, "Maria", "Gutierrez", "marigutierrez", "clave");
        private static Entidades.Administrativo administrativo1 = new(13, "Juan", "Gomez", "juangomez", "clave1");

        static protected List<Entidades.Persona> listaPersonas = new List<Entidades.Persona>();
        
        public static void AgregarPersona(Entidades.Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public static void InicializarLista()
        {
            AgregarPersona(alumno1);
            AgregarPersona(profesor1);
            AgregarPersona(administrativo1);
        }        

        public static Entidades.Persona GetPersonaPorUsuarioYContraseña(string usuario, string contraseña)
        {
            var persona = listaPersonas.FirstOrDefault(x => x.Usuario == usuario && x.Contraseña == contraseña);
            return persona;
        }
    }
}
