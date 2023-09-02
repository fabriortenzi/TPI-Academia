using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class InscripcionCursado
    {
        public static void AgregarInscripcion(Entidades.InscripcionCursado inscripcion)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.inscripciones_cursados.Attach(inscripcion);
                context.Entry(inscripcion).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public static List<Entidades.InscripcionCursado> GetAllInscripcion() 
        {
            List<Entidades.InscripcionCursado> incripciones = new();
            using (var context = ApplicationContext.CreateContext()) {
                if (context.inscripciones_cursados.ToList() != null) 
                { 
                incripciones = context.inscripciones_cursados.ToList();
                }
            }
            return incripciones;
        }

        public static List<Entidades.Usuario> GetAllAlumnosPorMateria(Entidades.Materia materia)
        {
            List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();
            using (var context = ApplicationContext.CreateContext())
            {
                var usuarios_inscriptos = from ins in context.inscripciones_cursados
                                          join usu in context.usuarios on ins.LegajoUsuario equals usu.Legajo
                                          where ins.Curso.Materia == materia
                                          select usu;
                                          

                usuarios = usuarios_inscriptos.ToList();
            }

            return usuarios;
        }


    }
}
