using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Persona
    {
        private static List<Entidades.Persona> personas = new List<Entidades.Persona>();

        public static void AgregarPersona(Entidades.Persona persona)
        {
            personas.Add(persona);
        }

        public static void EditarDatosPersona(Entidades.Persona persona, string direccion, string telefono)
        {
            var personaEditar = personas.FirstOrDefault(x => x == persona);
            
            // Edito solo si se modifico el campo
            
            if (personaEditar.Direccion != direccion)
            {
                personaEditar.Direccion = direccion;
            }

            if (personaEditar.Telefono != telefono)
            {
                personaEditar.Telefono = telefono;
            }
        }

        public static void EliminarPersona(Entidades.Persona persona)
        {
            personas.Remove(persona);
        }

        public static void InicializarListaPersonas()
        {
            Entidades.Persona persona1 = new(43127777, "Fabrizio", "Ortenzi", "Zeballos 1700", new DateTime(2001, 1, 10), "341500800");
            Entidades.Persona persona2 = new(43127778, "Juan", "Perez", "Italia 1600", new DateTime(2002, 6, 6), "341520800");
            Entidades.Persona persona3 = new(43127779, "Bianca", "Gomez", "Pellegrinni 1500", new DateTime(2000, 8, 22), "341570800");

            AgregarPersona(persona1);
            AgregarPersona(persona2);
            AgregarPersona(persona3);
        }

        public static Entidades.Persona GetPersonaPorDni(int dni) => personas.FirstOrDefault(x => x.Dni == dni);
    }
}
