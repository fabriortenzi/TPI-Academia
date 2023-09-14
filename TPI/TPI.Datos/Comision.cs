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
        public static Entidades.Comision GetComisionPorId(int idCom, int idEsp)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.comisiones
                    .FirstOrDefault(c => c.IdCom == idCom && c.IdEspecialidad == idEsp);
            }
        }

        public static Entidades.Comision GetComisionPorIdyDescEsp(string id_desc_esp) 
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.comisiones
                    .FirstOrDefault(c => (c.IdCom.ToString() + " " + c.Especialidad.descEspec) == id_desc_esp );
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
    }
}
