﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Persona
    {
        public int Dni { get; private set; }

        public string Nombre { get; private set; }

        public string Apellido { get; private set; }

        public string Direccion { get; private set; }

        public DateTime FechaNacimiento { get; private set; }

        public string Telefono { get; private set; }

        public Persona(int dni, string nombre, string apellido, string direccion, DateTime fechaNacimiento, string telefono)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }
    }
}
