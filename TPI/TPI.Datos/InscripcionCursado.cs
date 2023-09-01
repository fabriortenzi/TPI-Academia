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
    }
}
