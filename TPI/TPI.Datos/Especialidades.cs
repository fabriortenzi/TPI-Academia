using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Datos
{
    public class Especialidades
    {
        private static List<Entidades.Especialidad> especialidades = new List<Entidades.Especialidad>();

        public static void AgregarEspecialidades(Entidades.Especialidad especialidad, List<TPI.Entidades.Plan> planes)
        {
            especialidad.Planes = planes;
            especialidades.Add(especialidad);
        }

        public static void InicializarListaEspecialidades()
        {
            Entidades.Especialidad especialidad1 = new(1, "Ingenieria en Sistemas");

            Entidades.Especialidad especialidad2 = new(2, "Ingenieria Quimica");

            Entidades.Especialidad especialidad3 = new(3, "Ingenieria Civil");

            List<Entidades.Plan> planesExistentes = TPI.Datos.Plan.GetPlanes();

            foreach (var plan in planesExistentes)
            {
                switch (plan.anio)
                {
                    case 2008:
                        especialidad1.Planes.Add(plan);
                        break;
                    case 2023:
                        especialidad2.Planes.Add(plan);
                        break;

                }
            }

            AgregarEspecialidades(especialidad1, especialidad1.Planes);
            AgregarEspecialidades(especialidad2, especialidad2.Planes);
            AgregarEspecialidades(especialidad3, especialidad3.Planes);

        }

        public static List<Entidades.Especialidad> GetEspecialidades()
        {
            return especialidades;
        }

        public static Entidades.Especialidad GetEspecialidadPorDescripcion(string descripcion)
            => especialidades.FirstOrDefault(x => x.descEspec == descripcion);
    }
}