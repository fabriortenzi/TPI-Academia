using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                context.profesores_cursos.Attach(profesor_curso);
                context.Entry(profesor_curso).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public static Entidades.ProfesorCurso GetOne(int id)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.profesores_cursos
                    .Include(x=>x.Curso)
                    .Include(x => x.Usuario)
                    .FirstOrDefault(x => x.Id == id);
            }

        }


        public static List<Entidades.ProfesorCurso> GetAll()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.profesores_cursos
                    .Include(x => x.Curso)
                    .Include(x => x.Usuario)
                    .ToList();
            }
        }

        public static void Cambiar(Entidades.ProfesorCurso profesor_curso, string cargo, Entidades.Usuario usuario, Entidades.Curso curso)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                Entidades.ProfesorCurso profesor_cursoCambiar = context.profesores_cursos.FirstOrDefault(x => x == profesor_curso);
                

                    profesor_cursoCambiar.Cargo = cargo;
                    profesor_cursoCambiar.Usuario = usuario;
                    profesor_cursoCambiar.Curso = curso;

                context.SaveChanges();
                
            }
        }

        public static void Eliminar(Entidades.ProfesorCurso profesor_curso)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.profesores_cursos.Remove(profesor_curso);
                context.SaveChanges();             
            }
        }

    }
}
