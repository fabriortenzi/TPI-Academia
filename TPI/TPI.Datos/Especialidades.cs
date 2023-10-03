using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Especialidades
    {
        public static List<Entidades.Especialidad> GetEspecialidades()
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.especialidades.OrderBy(e => e.Descripcion).ToList();
            }
        }

        public static Entidades.Especialidad GetEspecialidad(string desc_Espec)
        {
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                return context.especialidades.FirstOrDefault(x => x.Descripcion.ToUpper() == desc_Espec.ToUpper());
            }
        }

        public async static Task<bool> CrearEspecialidad(Entidades.Especialidad especialidad)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                try
                {
                    var espE = GetEspecialidad(especialidad.Descripcion);
                    if (espE != null)
                    {
                        return false;
                    }

                    context.especialidades.Add(especialidad);
                    await context.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public async static Task<bool> ModificarEspecialidad(Entidades.Especialidad _especialidad)
        {
            try
            {
                using (var _context = ApplicationContext.CreateContext())
                {
                    var espE = GetEspecialidad(_especialidad.Descripcion);
                    if (espE != null)
                    {
                        return false;
                    }

                    _context.Entry(_especialidad).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}