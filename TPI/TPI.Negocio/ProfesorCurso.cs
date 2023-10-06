using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class ProfesorCurso
    {
        public static List<Entidades.ProfesorCurso> BuscarPorUsuario(Entidades.Usuario us) 
        {
            return Datos.ProfesorCurso.GetAll().Where(x=>x.Usuario.Legajo == us.Legajo).ToList();
        }

        public static Entidades.ProfesorCurso BuscarPorUsuarioCurso(Entidades.Usuario us, Entidades.Curso cu) 
        {
            return Datos.ProfesorCurso.GetAll().FirstOrDefault(x=>x.Curso.Id == cu.Id && x.Usuario.Legajo == us.Legajo);
        }

        public static void Agregar(Entidades.ProfesorCurso profesor_curso)
         => TPI.Datos.ProfesorCurso.Agregar(profesor_curso);
        public static void Eliminar(Entidades.ProfesorCurso profesor_curso)
         => TPI.Datos.ProfesorCurso.Eliminar(profesor_curso);
        public static void Cambiar(Entidades.ProfesorCurso profesor_curso, string cargo, Entidades.Usuario usuario, Entidades.Curso curso)
         => TPI.Datos.ProfesorCurso.Cambiar(profesor_curso, cargo, usuario, curso);
        public static Entidades.ProfesorCurso GetOne(int id)
        {
            return Datos.ProfesorCurso.GetOne(id);
        }
        public static List<Entidades.ProfesorCurso> GetAll()
        {
            return Datos.ProfesorCurso.GetAll();
        }
    }
}
