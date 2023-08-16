using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public interface IApplicationContextFactory
    {
        ApplicationContext CreateContext();
    }
}
