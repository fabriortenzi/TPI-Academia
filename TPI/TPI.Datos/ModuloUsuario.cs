using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    public class ModuloUsuario
    {
        public static List<Entidades.ModuloUsuario> ModulosUsuarios = new List<Entidades.ModuloUsuario>();

        public static void InicializarListaModulosUsuarios()
        {
            Entidades.TipoDeUsuario alumno = TipoDeUsuario.GetTipoAlumno();
            Entidades.TipoDeUsuario profesor = TipoDeUsuario.GetTipoProfesor();
            Entidades.TipoDeUsuario admin = TipoDeUsuario.GetTipoAdmin();

            // Modulos para la opcion Persona
            Entidades.Modulo moduloPersona = Modulo.GetModuloPersona();

            Entidades.ModuloUsuario moduloPersonaAlumno = new(moduloPersona, alumno, false, false, true, true);
            Entidades.ModuloUsuario moduloPersonaProfesor = new(moduloPersona, profesor, false, false, true, true);
            Entidades.ModuloUsuario moduloPersonaAdmin = new(moduloPersona, admin, true, false, true, true);


            // Modulos para la opcion Usuario
            Entidades.Modulo moduloUsuario = Modulo.GetModuloUsuario();

            Entidades.ModuloUsuario moduloUsuarioAlumno = new(moduloUsuario, alumno, false, false, true, true);
            Entidades.ModuloUsuario moduloUsuarioProfesor = new(moduloUsuario, profesor, false, false, true, false);
            Entidades.ModuloUsuario moduloUsuarioAdmin = new(moduloUsuario, admin, true, false, true, false);

            
            ModulosUsuarios.Add(moduloPersonaAlumno);
            ModulosUsuarios.Add(moduloPersonaProfesor);
            ModulosUsuarios.Add(moduloPersonaAdmin);
            ModulosUsuarios.Add(moduloUsuarioAlumno);
            ModulosUsuarios.Add(moduloUsuarioProfesor);
            ModulosUsuarios.Add(moduloUsuarioAdmin);
        }

        public static List<Entidades.ModuloUsuario> GetAllModulosUsuarios()
            => ModulosUsuarios;

        public static Entidades.ModuloUsuario GetModuloUsuario(Entidades.Modulo modulo, Entidades.TipoDeUsuario tipoDeUsuario)
            => ModulosUsuarios.FirstOrDefault(x => x.Modulo.Descripcion == modulo.Descripcion && x.TipoDeUsuario.Descripcion == tipoDeUsuario.Descripcion);
    }
}
