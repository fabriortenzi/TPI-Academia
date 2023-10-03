using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    class Cursado
    {
        public static void Agregar(Entidades.Cursado Cursado)
        => Datos.Cursado.Agregar(Cursado);

        public static void Eliminar(Entidades.Cursado Cursado)
        => Datos.Cursado.Eliminar(Cursado);
        public static void Cambiar(Entidades.Cursado cursado, Entidades.Usuario usuario, Entidades.Curso curso, DateTime fechahorains, int notafinal)
        => Datos.Cursado.Cambiar(cursado, usuario, curso, fechahorains, notafinal);


        public static List<Entidades.Cursado> GetAll()
        {
            return Datos.Cursado.GetAll();
        }
        public static Entidades.Cursado GetOne(int id)
        {
            return Datos.Cursado.GetOne(id);
        }
    }
}
