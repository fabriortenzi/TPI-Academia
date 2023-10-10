using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Comision
    {
        public static Entidades.Comision GetComisionPorId(int nroCom, Especialidad especialidad)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.comisiones
                    .FirstOrDefault(c => c.Id == nroCom && c.Especialidad == especialidad);
            }
        }

        public static Entidades.Comision GetComisionPorIdyDescEsp(string id_desc_esp)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.comisiones
                    .FirstOrDefault(c => (c.Id.ToString() + " " + c.Especialidad.Descripcion) == id_desc_esp);
            }
        }


        public static List<Entidades.Comision> GetAll()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context
                    .comisiones
                    .Include(c => c.Especialidad)
                    .ToList();
            }
        }

        public static void AgregarComision(Entidades.Comision comision)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.comisiones.Attach(comision);
                context.Entry(comision).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public static Entidades.Comision GetOne(int id)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.comisiones
                       .Include(x => x.Especialidad)
                       .FirstOrDefault(x => x.Id == id);

            }

        }
        public static void Cambiar(Entidades.Comision comision, int nroComision, Entidades.Especialidad especialidad)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                Entidades.Comision comisionACambiar = context.comisiones.FirstOrDefault(x => x == comision);
                comisionACambiar.NroComision = nroComision;
                comisionACambiar.Especialidad = especialidad;
                context.SaveChanges();
            }
        }
        public static void Eliminar(Entidades.Comision comision) 
        {
            using (var context = ApplicationContext.CreateContext())
            {
                //Hay que eliminar todos los cursos de dicha comision editar .OnDelete(DeleteBehavior.Cascade)
                context.comisiones.Remove(comision);
                context.SaveChanges();
            }

        }

    }
}
