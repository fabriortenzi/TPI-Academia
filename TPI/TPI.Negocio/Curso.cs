using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Curso
    {
        public static List<Entidades.Curso> BuscarCursosPorPlanCicloLectivo(Entidades.Plan plan, int ciclo) 
        {
            return TPI.Datos.Curso.GetAll().Where(x => x.Materia.Plan == plan && x.CicloLectivo == ciclo).ToList();
        }
        public static Entidades.Curso BuscarCursoPorMateriaComision(Entidades.Materia materia, Entidades.Comision comision) 
        {
            return TPI.Datos.Curso.GetAll().FirstOrDefault(x => x.Materia == materia && x.Comision == comision);
        }
        public static Entidades.Curso Crear(Entidades.Materia materia, int ciclo, Entidades.Comision comision, int cupo,  string dia, TimeSpan hora_ini, TimeSpan hora_fin) 
        {
            return new Entidades.Curso(materia, ciclo, comision, cupo, dia, hora_ini, hora_fin);
        }

        public static void Agregar(Entidades.Curso curso)
        => Datos.Curso.Agregar(curso);

        public static void Eliminar(Entidades.Curso curso)
        => Datos.Curso.Eliminar(curso);

        public static void Cambiar(Entidades.Curso curso, int ciclo, Entidades.Materia materia, Entidades.Comision comision, int cupo, string dia, TimeSpan hora_ini, TimeSpan hora_fin)
       => Datos.Curso.Cambiar(curso, ciclo, materia, comision, cupo, dia, hora_ini, hora_fin);

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
