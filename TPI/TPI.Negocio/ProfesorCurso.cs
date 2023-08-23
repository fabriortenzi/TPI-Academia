using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class ProfesorCurso
    {

        public static void Agregar(Entidades.ProfesorCurso profesor_curso)
        {
            TPI.Datos.ProfesorCurso.Agregar(profesor_curso);
        }

        public static Entidades.ProfesorCurso GetProfesorCurso(int legajo, int anio, int id_materia)
        {
            return TPI.Datos.ProfesorCurso.GetProfesorCurso(legajo, anio, id_materia);
        }
        public static List<Entidades.ProfesorCurso> GetAllProfesorCurso()
        {
            return TPI.Datos.ProfesorCurso.GetAllProfesorCurso();
        }
        public static void Cambiar(Entidades.ProfesorCurso profesor_curso, string cargo)
        {
            TPI.Datos.ProfesorCurso.Cambiar(profesor_curso, cargo);
        }
        public static void Eliminar(Entidades.ProfesorCurso profesor_curso)
        {
            TPI.Datos.ProfesorCurso.Eliminar(profesor_curso);
        }
    }
}
