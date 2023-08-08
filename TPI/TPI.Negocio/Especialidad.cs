﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Especialidad
    {
        public static List<Entidades.Especialidad> GetAllEspecialidades()
            => Datos.Especialidades.GetEspecialidades();


        public static TPI.Entidades.Especialidad Getespecialidadpordesc(string especialidad)
        {
            return Datos.Especialidades.GetEspecialidad(especialidad);
        }

       
    }
}
    