using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class ProfesorCurso
    {
        public static void Agregar(Entidades.ProfesorCurso profesor_curso)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.profesores_cursos.Add(profesor_curso);
                context.SaveChanges();
            }
        }

        public static Entidades.ProfesorCurso GetProfesorCurso(int legajo, int anio, int id_materia)
        {
            Entidades.ProfesorCurso profesor_curso = null;

            using (var context = ApplicationContext.CreateContext())
            {
                profesor_curso = context.profesores_cursos.FirstOrDefault(x => x.Usuario.Legajo == legajo && x.Curso.CicloLectivo == anio && x.Curso.Materia.Id == id_materia);
            }

            return profesor_curso;
        }


        public static List<Entidades.ProfesorCurso> GetAllProfesorCurso()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.profesores_cursos.ToList();
            }
        }

        public static void Cambiar(Entidades.ProfesorCurso profesor_curso, string cargo)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var profesor_cursoCambiar = context.profesores_cursos.FirstOrDefault(x => x == profesor_curso);
                if (profesor_cursoCambiar != null)
                {

                    profesor_cursoCambiar.Cargo = cargo;
                    

                    context.SaveChanges();
                }
            }
        }

        public static void Eliminar(Entidades.ProfesorCurso profesor_curso)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var profesor_cursoEliminar = context.profesores_cursos.FirstOrDefault(x => x == profesor_curso);
                if (profesor_cursoEliminar != null)
                {
                    context.profesores_cursos.Remove(profesor_cursoEliminar);
                    context.SaveChanges();
                }

            }
        }

    }
}
