using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Especialidad
    {
        public static List<Entidades.Especialidad> GetAllEspecialidades()
            => Datos.Especialidades.GetEspecialidades();

        public static TPI.Entidades.Especialidad Getespecialidadpordesc(string especialidad)
        {
            return Datos.Especialidades.GetEspecialidad(especialidad);
        }       

        public async static Task<bool> CrearEspecialidad(string descripcion)
        {
            var especialidad = new Entidades.Especialidad(descripcion);
            return await Datos.Especialidades.CrearEspecialidad(especialidad);
        }

        public async static Task<bool> ModificarEspecialidad(Entidades.Especialidad _especialidad)
            => await Datos.Especialidades.ModificarEspecialidad(_especialidad);
    }
}
    
