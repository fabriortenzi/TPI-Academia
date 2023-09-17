using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcademiaWeb.Models;

namespace AcademiaWeb.Data
{
    public class AcademiaWebContext : DbContext
    {
        public AcademiaWebContext (DbContextOptions<AcademiaWebContext> options)
            : base(options)
        {
        }

        public async Task<List<Persona>> ObtenerPersonasAsync()
        {
            return await Persona.ToListAsync();
        }

        public async Task<List<TipoDeUsuario>> ObtenerTiposDeUsuarioAsync()
        {
            return await TipoDeUsuario.ToListAsync();
        }

        public async Task<List<Especialidad>> ObtenerEspecialidadesAsync()
        {
            return await Especialidad.ToListAsync();
        }

        public DbSet<AcademiaWeb.Models.Persona> Persona { get; set; }

        public DbSet<AcademiaWeb.Models.Usuario> Usuario { get; set; }

        public DbSet<AcademiaWeb.Models.TipoDeUsuario> TipoDeUsuario { get; set; }

        public DbSet<AcademiaWeb.Models.Comision> Comision { get; set; }

        public DbSet<AcademiaWeb.Models.Curso> Curso { get; set; }

        public DbSet<AcademiaWeb.Models.Especialidad> Especialidad { get; set; }

        public DbSet<AcademiaWeb.Models.Plan> Plan { get; set; }
    }
}
