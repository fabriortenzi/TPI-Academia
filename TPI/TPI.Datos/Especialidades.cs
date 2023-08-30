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
        public static List<Entidades.Especialidad> GetEspecialidades()
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.especialidades.ToList();
            }
        }

        public static Entidades.Especialidad GetEspecialidad(string desc_Espec)
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.especialidades.FirstOrDefault(x => x.descEspec == desc_Espec);
            }
        }
    }
}