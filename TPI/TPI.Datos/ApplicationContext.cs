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

        public DbSet<Entidades.MateriaAprobada> materias_aprobadas { get; set; }

        public DbSet<Entidades.MateriaComision> materias_comisiones { get; set; }

        public DbSet<Entidades.ProfesorCurso> profesores_cursos { get; set; }
        
        public DbSet<Entidades.Evaluacion> evaluaciones { get; set; }

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

            modelBuilder.Entity<Entidades.MateriaAprobada>()
                .HasKey(e => new { e.idMateria, e.Legajo });

            modelBuilder.Entity<Entidades.MateriaComision>()
               .HasKey(e => new { e.idMateria, e.idEspecialidad, e.IdCom });
            
            modelBuilder.Entity<Entidades.ProfesorCurso>()
               .HasKey(e => new { e.idMateria, e.Legajo, e.Anio });

            modelBuilder.Entity<Entidades.Evaluacion>()
              .HasKey(e => new { e.idEvaluacion});
        }
    }
}
