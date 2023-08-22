using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class MateriaAprobada
    {
        public static void Agregar(Entidades.MateriaAprobada materia_aprobada)
        {
            TPI.Datos.MateriaAprobada.Agregar(materia_aprobada);
        }

        public static Entidades.MateriaAprobada GetMateriaAprobada(int legajo, int id_materia)
        {
            return TPI.Datos.MateriaAprobada.GetMateriaAprobada(legajo, id_materia);
        }
        public static List<Entidades.MateriaAprobada> GetAllMateriaAprobada()
        {
           return TPI.Datos.MateriaAprobada.GetAllMateriaAprobada();
        }
        public static void Cambiar(Entidades.MateriaAprobada materia_aprobada, int nueva_nota) 
        {
          TPI.Datos.MateriaAprobada.Cambiar(materia_aprobada, nueva_nota);
        }
        public static void Eliminar(Entidades.MateriaAprobada materia_aprobada) 
        {
            TPI.Datos.MateriaAprobada.Eliminar(materia_aprobada);
        }
        


    }
}
