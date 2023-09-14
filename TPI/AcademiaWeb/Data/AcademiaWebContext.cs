using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TPI.Entidades;

namespace AcademiaWeb.Data
{
    public class AcademiaWebContext : DbContext
    {
        public AcademiaWebContext (DbContextOptions<AcademiaWebContext> options)
            : base(options)
        {
        }

        public DbSet<TPI.Entidades.Persona> Persona { get; set; }
    }
}
