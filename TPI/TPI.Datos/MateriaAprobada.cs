using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class MateriaAprobada
    {
        public static void Agregar(Entidades.MateriaAprobada materia_aprobada)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.materias_aprobadas.Add(materia_aprobada);
                context.SaveChanges();
            }
        }

        public static Entidades.MateriaAprobada GetMateriaAprobada(int legajo, int id_materia)
        {
            Entidades.MateriaAprobada materia_aprobada = null;

            using (var context = ApplicationContext.CreateContext())
            {
                materia_aprobada = context.materias_aprobadas.FirstOrDefault(x => x.Legajo == legajo && x.idMateria == id_materia);
            }

            return materia_aprobada;
        }


        public static List<Entidades.MateriaAprobada> GetAllMateriaAprobada()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.materias_aprobadas.ToList();
            }
        }

        public static void Cambiar(Entidades.MateriaAprobada materia_aprobada, int nueva_nota)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var materia_aprobadaCambiar = context.materias_aprobadas.FirstOrDefault(x => x == materia_aprobada);
                materia_aprobadaCambiar.Nota = nueva_nota;
                context.SaveChanges();
            }
        }

        public static void Eliminar(Entidades.MateriaAprobada materia_aprobada) 
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var materia_aprobadaEliminar = context.materias_aprobadas.FirstOrDefault(x=>x== materia_aprobada);
                if (materia_aprobadaEliminar != null) 
                {
                    context.materias_aprobadas.Remove(materia_aprobadaEliminar);
                    context.SaveChanges();
                }

            }


        }

    }
}

