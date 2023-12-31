﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Persona
    {
        public static void AgregarPersona(Entidades.Persona persona)
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                context.personas.Add(persona);
                context.SaveChanges();
            }
        }

        public static void EditarDatosPersona(Entidades.Persona persona)
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                context.personas.Attach(persona);
                context.Entry(persona).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void EliminarPersona(Entidades.Persona persona)
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                context.personas.Remove(persona);
                context.SaveChanges();
            }
        }

        public static Entidades.Persona GetPersonaPorDni(int dni)
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.personas.FirstOrDefault(x => x.Dni == dni);
            }
        }

        public static List<Entidades.Persona> GetAll()
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.personas.ToList();
            }

        }
    }
}
