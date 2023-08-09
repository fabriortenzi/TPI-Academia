using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Curso
    {
        private static List<Entidades.Curso> cursos = new();

        public static void AgregarCurso(Entidades.Curso curso)
        {
            cursos.Add(curso);
        }
    }
}
