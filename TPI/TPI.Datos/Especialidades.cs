using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Especialidades
    {
        private static List<Entidades.Especialidad> especialidades = new List<Entidades.Especialidad>();

        public static void AgregarEspecialidades(Entidades.Especialidad especialidad)
        {

            especialidades.Add(especialidad);
        }

        public static void InicializarListaEspecialidades()
        {
            Entidades.Especialidad especialidad1 = new(1, "Ingenieria en Sistemas");

            Entidades.Especialidad especialidad2 = new(2, "Ingenieria Quimica");

            Entidades.Especialidad especialidad3 = new(3, "Ingenieria Civil");

            AgregarEspecialidades(especialidad1);
            AgregarEspecialidades(especialidad2);
            AgregarEspecialidades(especialidad3);

        }

        public static List<Entidades.Especialidad> GetEspecialidades()
        {
            return especialidades;
        }

        public static Entidades.Especialidad  GetEspecialidad(string desc_Espec) => especialidades.FirstOrDefault( x => x.descEspec == desc_Espec);


    }
}