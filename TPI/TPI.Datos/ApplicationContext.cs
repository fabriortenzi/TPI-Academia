using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TPI.Datos
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Entidades.Persona> personas { get; set; }

        public DbSet<Entidades.TipoDeUsuario> tipos_de_usuario { get; set; }

        public DbSet<Entidades.Usuario> usuarios { get; set; }

        public DbSet<Entidades.Modulo> modulos { get; set; }

        public DbSet<Entidades.ModuloUsuario> modulos_usuarios { get; set; }

        public DbSet<Entidades.InscripcionCursado> inscripciones_cursados { get; set; }

        public DbSet<Entidades.Curso> cursos { get; set; }

        public DbSet<Entidades.Comisiones> comisiones { get; set; }

        public DbSet<Entidades.Materia> materias { get; set; }

        public DbSet<Entidades.Especialidad> especialidades { get; set; }

        public DbSet<Entidades.Plan> planes { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> contextOptions)
            : base(contextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.ModuloUsuario>()
                .HasKey(e => new { e.IdModulo, e.IdTipoDeUsuario });

            modelBuilder.Entity<Entidades.Comisiones>()
                .HasKey(e => new { e.IdCom, e.IdEspecialidad });

            modelBuilder.Entity<Entidades.Curso>()
                .HasKey(e => new { e.IdMateria, e.Año });

            modelBuilder.Entity<Entidades.InscripcionCursado>()
                .HasKey(e => new { e.LegajoUsuario, e.FechaHora });

            modelBuilder.Entity<Entidades.Plan>()
                .HasKey(e => new { e.IdEspecialidad, e.anio });
        }
    }
}
