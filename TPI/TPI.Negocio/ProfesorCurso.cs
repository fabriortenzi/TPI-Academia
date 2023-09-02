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
        public static List<Entidades.Curso> GetCursos()
        {
            List<Entidades.ProfesorCurso> profesores_cursos = TPI.Datos.ProfesorCurso.GetAllProfesorCurso();

            List<Entidades.Curso> cursos = new();

            foreach (Entidades.ProfesorCurso pf in profesores_cursos)
            {
               if( !(cursos.Contains(pf.Curso)) ) { 
               cursos.Add(pf.Curso);
                }
            }

            return cursos ;
        }

        public static List<Entidades.Curso> GetCursos(Entidades.Usuario profesor)
        {
            List<Entidades.ProfesorCurso> profesores_cursos = TPI.Datos.ProfesorCurso.GetAllProfesorCurso();

            List<Entidades.Curso> cursos = new();

            var pc = profesores_cursos.Where(x => x.Usuario == profesor);


            foreach (var pf in pc)
            {
                if (!(cursos.Contains(pf.Curso)))
                {
                    cursos.Add(pf.Curso);
                }
            }

            return cursos;
        }

        public static List<Entidades.Materia> GetMaterias_Cursos(Entidades.Usuario profesor) 
        {
           
            List<TPI.Entidades.Curso> cursos = GetCursos(profesor);
            List<TPI.Entidades.Materia> materias = new();

            foreach (TPI.Entidades.Curso c in cursos)
            {
             if( !(materias.Contains(c.Materia))) 
                {
                    materias.Add(c.Materia);    
                }  
                
            }
            return materias;
        }



    }
}
