using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TPI.Datos
{
    public class ApplicationContextDesignTimeFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=tpi2023tm01;Integrated Security=true;");

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
