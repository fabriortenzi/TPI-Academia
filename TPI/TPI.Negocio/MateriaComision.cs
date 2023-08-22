using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class MateriaComision
    {


        public static void Agregar(Entidades.MateriaComision materia_comision)
        {
            TPI.Datos.MateriaComision.Agregar(materia_comision);
        }

        public static Entidades.MateriaComision GetMateriaComision(int id_materia, int id_especialidad, int id_comision)
        {
            return TPI.Datos.MateriaComision.GetMateriaComision(id_materia, id_especialidad, id_comision);
        }
        public static List<Entidades.MateriaComision> GetAllMateriaComision()
        {
            return TPI.Datos.MateriaComision.GetAllMateriaComision();
        }
        public static void Cambiar(Entidades.MateriaComision materia_comision, int Cupo, int dia, TimeSpan hora_inicio, TimeSpan hora_fin)
        {
            TPI.Datos.MateriaComision.Cambiar(materia_comision, Cupo, dia, hora_inicio, hora_fin);
        }
        public static void Eliminar(Entidades.MateriaComision materia_comision)
        {
            TPI.Datos.MateriaComision.Eliminar(materia_comision);
        }


    }
    
}
    
