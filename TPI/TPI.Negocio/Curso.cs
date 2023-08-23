﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Curso
    {
        public static Entidades.Curso CrearCurso(int año, int cupo, Entidades.Materia materia)
            => new Entidades.Curso(materia, año, cupo);

        public static void AgregarCurso(Entidades.Curso curso)
        {
            Datos.Curso.AgregarCurso(curso);
        }
    }
}
