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

        public DbSet<AcademiaWeb.Models.Persona> Persona { get; set; }
    }
}
