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

            Entidades.ModuloUsuario moduloPersonaAlumno = new(moduloPersona, alumno, false, false, false, true);
            Entidades.ModuloUsuario moduloPersonaProfesor = new(moduloPersona, profesor, false, false, false, true);
            Entidades.ModuloUsuario moduloPersonaAdmin = new(moduloPersona, admin, true, true, true, true);


            // Modulos para la opcion Usuario
            Entidades.Modulo moduloUsuario = Modulo.GetModuloUsuario();

            Entidades.ModuloUsuario moduloUsuarioAlumno = new(moduloUsuario, alumno, false, false, false, true);
            Entidades.ModuloUsuario moduloUsuarioProfesor = new(moduloUsuario, profesor, false, false, false, true);
            Entidades.ModuloUsuario moduloUsuarioAdmin = new(moduloUsuario, admin, true, true, true, true);

            
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
            => ModulosUsuarios.FirstOrDefault(x => x.Modulo == modulo && x.TipoDeUsuario == tipoDeUsuario);
    }
}
