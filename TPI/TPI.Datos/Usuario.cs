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
    public class Usuario
    {
        public static void AgregarUsuario(Entidades.Usuario usuario)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.usuarios.Attach(usuario);
                context.Entry(usuario).State = EntityState.Added;
                context.SaveChanges();
            }            
        } 

        public static Entidades.Usuario GetUsuarioPorLegajoYContraseña(int legajo, string contraseña)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.usuarios
                    .Include(x => x.TipoDeUsuario)
                    .Include(x => x.Persona)
                    .Include(x => x.Plan)
                    .FirstOrDefault(x => x.Legajo == legajo && x.Contraseña == contraseña);
            }
        }

        public static List<Entidades.Usuario> GetAllUsuarios()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.usuarios
                    .Include(x => x.TipoDeUsuario)
                    .Include(x => x.Persona)
                    .ToList();
            }
        }

        public static void CambiarContraseña(Entidades.Usuario usuario, string nuevaCont)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var usuarioCambiar = context.usuarios.FirstOrDefault(x => x == usuario);
                usuarioCambiar.Contraseña = nuevaCont;
                context.SaveChanges();
            }
        }

        public static void AsignarPlanAUsuario(Entidades.Plan _Plan, Entidades.Usuario Usuario)
        {
            Usuario.Plan = _Plan;
            using (ApplicationContext context = ApplicationContext.CreateContext())
            {
                context.usuarios.Attach(Usuario);
                context.Entry(Usuario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
