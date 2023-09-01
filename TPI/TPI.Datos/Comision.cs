using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class Comision
    {
        public static Entidades.Comisiones GetComisionPorId(int idCom, int idEsp)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.comisiones
                    .FirstOrDefault(c => c.IdCom == idCom && c.IdEspecialidad == idEsp);
            }
        }
    }
}
