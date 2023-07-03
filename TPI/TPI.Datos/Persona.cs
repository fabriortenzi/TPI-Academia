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
        private readonly Alumno alumno1 = new Alumno(123, "Fabri", "Ortenzi", "clave", 47, "fabriortenzi");
        private readonly Profesor profesor1 = new Profesor(12, "Maria", "Gutierrez", "clave", 47, "marigutierrez");
        private readonly Administrativo administrativo1 = new Administrativo(13, "Juan", "Gomez", "clave1", "juangomez");

        List<Entidades.Persona> listaPersonas = new List<Entidades.Persona>();
        
        private void agregarPersona(Entidades.Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public Persona()
        {
            agregarPersona(alumno1);
            agregarPersona(profesor1);
            agregarPersona(administrativo1);
        }        

        public Entidades.Persona getPersonaPorUsuarioYContraseñaDatos(string usuario, string contraseña)
        {
            var persona = listaPersonas.FirstOrDefault(x => x.Usuario == usuario && x.Contraseña == contraseña);
            return persona;
        }
    }
}
