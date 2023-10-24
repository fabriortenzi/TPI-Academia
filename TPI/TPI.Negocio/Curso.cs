using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Curso
    {
        public static List<Entidades.Curso> BuscarCursosPorPlanCicloLectivo(Entidades.Usuario usuario, int ciclo) 
        {
            // Obtengo todos los Cursos del Plan
            var cursos = TPI.Datos.Curso.GetAll()
                .Where(x => x.Materia.Plan.Id == usuario.Plan.Id && x.CicloLectivo == ciclo)
                .ToList();

            // Obtengo los Cursos a los que se inscribio el Alumno este Ciclo Lectivo
            var cursosInsc = Cursado.BuscarCursadosPorUsuarioAño(usuario, ciclo).Select(c => c.Curso).ToList();

            // Saco de la lista de cursos para inscribirse los que el Alumno ya se inscribio
            cursos.RemoveAll(curso => cursosInsc.Any(cursoInsc => cursoInsc.Id == curso.Id));
            return cursos;
        }

        public static Entidades.Curso BuscarCursoPorMateriaComision(Entidades.Materia materia, Entidades.Comision comision) 
        {
            return TPI.Datos.Curso.GetAll().FirstOrDefault(x => x.Materia.Id == materia.Id && x.Comision.Id == comision.Id);
        }
        public static Entidades.Curso Crear(Entidades.Materia materia, int ciclo, Entidades.Comision comision, int cupo,  string dia, TimeSpan hora_ini, TimeSpan hora_fin) 
        {
            return new Entidades.Curso(materia, ciclo, comision, cupo, dia, hora_ini, hora_fin);
        }

        public static void Agregar(Entidades.Curso curso)
        => Datos.Curso.Agregar(curso);

        public static void Eliminar(Entidades.Curso curso)
        => Datos.Curso.Eliminar(curso);

        public static void Cambiar(Entidades.Curso curso)
       => Datos.Curso.Cambiar(curso);

        public static List<Entidades.Curso> GetAll()
        {
            return Datos.Curso.GetAll();
        }
        public static Entidades.Curso GetOne(int id)
        {
            return Datos.Curso.GetOne(id);
        }
    }
}
