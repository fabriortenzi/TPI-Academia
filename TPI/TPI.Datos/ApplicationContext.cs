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

        public DbSet<Entidades.Cursado> cursados { get; set; }

        public DbSet<Entidades.Curso> cursos { get; set; }

        public DbSet<Entidades.Comision> comisiones { get; set; }

        public DbSet<Entidades.Materia> materias { get; set; }

        public DbSet<Entidades.Especialidad> especialidades { get; set; }

        public DbSet<Entidades.Plan> planes { get; set; }

        public DbSet<Entidades.ProfesorCurso> profesores_cursos { get; set; }
 

        public ApplicationContext(DbContextOptions<ApplicationContext> contextOptions)
            : base(contextOptions) { }

        public static ApplicationContext CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=tpi2023tm01;Integrated Security=true;");

            return new ApplicationContext(optionsBuilder.Options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Comision>()
                .HasKey(c => new { c.Id });

            modelBuilder.Entity<Entidades.Cursado>()
                .HasKey(c => new { c.Id });

            modelBuilder.Entity<Entidades.Curso>()
                .HasKey(c => new { c.Id });

            modelBuilder.Entity<Entidades.Especialidad>()
                .HasKey(e => new { e.Id });

            modelBuilder.Entity<Entidades.Materia>()
                .HasKey(m => new { m.Id });

            modelBuilder.Entity<Entidades.Plan>()
               .HasKey(p => new { p.Id });

            modelBuilder.Entity<Entidades.ProfesorCurso>()
               .HasKey(pc => new { pc.Id });

            modelBuilder.Entity<Entidades.TipoDeUsuario>()
               .HasKey(t => new { t.Id });

            modelBuilder.Entity<Entidades.Usuario>()
               .HasKey(u => new { u.Legajo });
        }
    }
}
