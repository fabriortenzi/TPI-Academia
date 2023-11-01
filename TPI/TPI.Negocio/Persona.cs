using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Persona
    {
        public static Entidades.Persona CrearPersona(int dni, string nombre, string apellido, string direccion, DateTime fechaNacimiento, string telefono)
        {
            Entidades.Persona persona = new(dni, nombre, apellido, direccion, fechaNacimiento, telefono);
            return persona;
        }

        public static Entidades.Persona GetPersonaPorDni(int dni) =>
            Datos.Persona.GetPersonaPorDni(dni);

        public static void AgregarPersona(Entidades.Persona persona)
        {
            Datos.Persona.AgregarPersona(persona);
        }

        public static void EditarDatosPersona(Entidades.Persona persona, string direccion, string telefono)
        {
            // Edito solo si se modifico el campo

            if (persona.Direccion != direccion)
            {
                persona.Direccion = direccion;
            }

            if (persona.Telefono != telefono)
            {
                persona.Telefono = telefono;
            }

            Datos.Persona.EditarDatosPersona(persona);
        }

        public static void EliminarPersona(Entidades.Persona persona)
        {
            Datos.Persona.EliminarPersona(persona);
        }
        public static List<Entidades.Persona> GetAll()
        {
            return Datos.Persona.GetAll();
        }
        
        // Para el form Editar
        public static bool ValidarDatos(string direccion, string telefono)
        {
            if (String.IsNullOrEmpty(direccion))
            {
                throw new Exception("Ingrese una direccion");
            }
            if (String.IsNullOrEmpty(telefono))
            {
                throw new Exception("Ingrese un telefono");
            }

            return true;
        }

        // Para el form Crear
        public static bool ValidarDatos(string dni, string nombre, string apellido, string direccion, string telefono, string dia, string mes, string anio)
        {
            if (String.IsNullOrEmpty(dni))
            {
                throw new Exception("Ingrese un DNI");
            }
            if (!dni.All(char.IsDigit))
            {
                throw new Exception("El DNI solo puede contener numeros");
            }
            if (dni.Length > 10)
            {
                throw new Exception("El DNI no puede tener mas de 10 digitos");
            }

            // Valido que la Persona no este repetida
            var persona = GetPersonaPorDni(Convert.ToInt32(dni));
            if (persona != null)
            {
                throw new Exception("Ya existe una persona con ese DNI");
            }


            if (String.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese un nombre");
            }
            if (nombre.Length > 20)
            {
                throw new Exception("El nombre no puede tener mas de 20 caracteres");
            }
            if (String.IsNullOrEmpty(apellido))
            {
                throw new Exception("Ingrese un apellido");
            }
            if (apellido.Length > 20)
            {
                throw new Exception("El apellido no puede tener mas de 20 caracteres");
            }
            if (String.IsNullOrEmpty(direccion))
            {
                throw new Exception("Ingrese una direccion");
            }
            if (direccion.Length > 20)
            {
                throw new Exception("La direccion no puede tener mas de 20 caracteres");
            }
            if (String.IsNullOrEmpty(telefono))
            {
                throw new Exception("Ingrese un telefono");
            }
            if (telefono.Length > 20)
            {
                throw new Exception("El telefono no puede tener mas de 20 caracteres");
            }

            // Valido la fecha
            DateTime fecha;
            try
            {
                fecha = new DateTime(Convert.ToInt32(anio), Convert.ToInt32(mes), Convert.ToInt32(dia));                
            }
            catch
            {
                throw new Exception("Error al ingresar los campos de la fecha");
            }

            if (fecha < new DateTime(1920, 01, 01))
            {
                throw new Exception("La fecha no puede ser menor al 1/1/1920");
            }
            else if (fecha > DateTime.Now)
            {
                throw new Exception("La fecha no puede ser mayor a hoy");
            }

            return true;
        }
    }
}
