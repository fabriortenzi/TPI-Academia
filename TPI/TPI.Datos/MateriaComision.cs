using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class MateriaComision
    {
        public static void Agregar(Entidades.MateriaComision materia_comision)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                context.materias_comisiones.Add(materia_comision);
                context.SaveChanges();
            }
        }

        public static Entidades.MateriaComision GetMateriaComision(int id_materia, int id_especialidad, int id_comision)
        {
            Entidades.MateriaComision materia_comision = null;

            using (var context = ApplicationContext.CreateContext())
            {
                materia_comision = context.materias_comisiones.FirstOrDefault(x => x.idMateria == id_materia && x.IdEspecialidad == id_especialidad && x.IdCom == id_comision);
            }

            return materia_comision;
        }


        public static List<Entidades.MateriaComision> GetAllMateriaComision()
        {
            using (var context = ApplicationContext.CreateContext())
            {
                return context.materias_comisiones.ToList();
            }
        }

        public static void Cambiar(Entidades.MateriaComision materia_comision, int Cupo, int dia, TimeSpan hora_inicio, TimeSpan hora_fin )
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var materia_comisionCambiar = context.materias_comisiones.FirstOrDefault(x => x == materia_comision);
                if (materia_comisionCambiar != null) {

                    materia_comisionCambiar.Cupo = Cupo;
                    materia_comisionCambiar.dia = dia;
                    materia_comisionCambiar.hora_ini = hora_inicio;
                    materia_comisionCambiar.hora_fin = hora_fin;

                    context.SaveChanges();
                }
            }
        }

        public static void Eliminar(Entidades.MateriaComision materia_comision)
        {
            using (var context = ApplicationContext.CreateContext())
            {
                var materia_comisionEliminar = context.materias_comisiones.FirstOrDefault(x => x == materia_comision);
                if (materia_comisionEliminar != null)
                {
                    context.materias_comisiones.Remove(materia_comisionEliminar);
                    context.SaveChanges();
                }

            }
        }

      }
    }
