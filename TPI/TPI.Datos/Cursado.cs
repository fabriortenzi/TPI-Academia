using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Cursado
    {
        public static void Agregar(Entidades.Cursado cursado) 
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.cursados.Attach(cursado);
                context.Entry(cursado).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public static void Eliminar(Entidades.Cursado cursado)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.Remove(cursado);
                context.SaveChanges();
            }
        }

        public static void Cambiar(Entidades.Cursado cursado, Entidades.Usuario usuario, Entidades.Curso curso, DateTime fechahorains, int notafinal)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                Entidades.Cursado cursadoACambiar = context.cursados.FirstOrDefault(x => x == cursado);
                cursadoACambiar.Usuario = usuario;
                cursadoACambiar.Curso = curso;
                cursadoACambiar.FechaHoraInscripcion = fechahorains;
                cursadoACambiar.NotaFinal = notafinal;
                context.SaveChanges();
            }
        }
        public static Entidades.Cursado GetOne(int id)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.cursados
                    .Include(x=>x.Usuario)
                    .Include(x => x.Curso)
                    .FirstOrDefault(x=>x.Id == id);
                
            }

        }
        public static List<Entidades.Cursado> GetAll()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.cursados
                     .Include(x => x.Usuario)
                     .Include(x => x.Curso)
                     .ToList();


            }

        }
    }
}
