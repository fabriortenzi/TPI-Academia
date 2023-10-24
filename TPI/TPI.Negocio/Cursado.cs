using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Negocio
{
    public class Cursado
    {
        public static bool ValidarNota(int nota)
        {
            if (nota >= 0 && nota <= 10) { return true; }
            else { return false; }
        }
    
            
        
        public static Entidades.Cursado BuscarCursoPorUsuarioCurso(Entidades.Usuario usuario, Entidades.Curso curso) 
        {
            var cur = Datos.Cursado.GetAll().FirstOrDefault(x => x.Usuario.Legajo == usuario.Legajo && x.Curso.Id == curso.Id);
            
            if (cur == null)
            {
                return null;
            }
            else
            {
                return Datos.Cursado.GetOne(cur.Id); 
            }
        }
        public static List<Entidades.Cursado> BuscarCursadosPorUsuarioAño(Entidades.Usuario usuario, int ciclo)
        {
            return TPI.Datos.Cursado.GetAll().Where(x => x.Usuario.Legajo == usuario.Legajo && x.Curso.CicloLectivo == ciclo).ToList();
        }
        public static List<Entidades.Cursado> BuscarCursadosPorAño(int year) 
        {
            return TPI.Datos.Cursado.GetAll().Where(x => x.Usuario.Plan.Anio == year).ToList();
        }
        public static Entidades.Cursado Crear(Entidades.Usuario usuario, Entidades.Curso curso, DateTime fechaHoraInscripcion) 
        {
            TPI.Datos.Curso.DescontarCupo(curso);
            return new Entidades.Cursado(usuario, curso, fechaHoraInscripcion);
        }
        public static void Agregar(Entidades.Cursado Cursado)
        => Datos.Cursado.Agregar(Cursado);

        public static void Eliminar(Entidades.Cursado Cursado)
        => Datos.Cursado.Eliminar(Cursado);

        public static void Cambiar(Entidades.Cursado cursado)
        {              
            Datos.Cursado.Cambiar(cursado);
        }

        public static bool ValidarCurso(Entidades.Usuario us, Entidades.Curso curso) 
        {

            bool f1 = true;
            foreach(Entidades.Cursado cursado in BuscarCursadosPorUsuarioAño(us, curso.CicloLectivo)) 
            {
                if (cursado.Curso.Id!=curso.Id)
                {

                    if (!((cursado.Curso.HoraInicio < curso.HoraInicio && cursado.Curso.HoraFin <= curso.HoraInicio) || (cursado.Curso.HoraInicio >= curso.HoraFin && cursado.Curso.HoraFin > curso.HoraFin)))
                    { f1 = false; break; }

                }

            }

            return f1;
            
        }
            public static List<Entidades.Cursado> GetAll()
        {
            return Datos.Cursado.GetAll();
        }
        public static Entidades.Cursado GetOne(int id)
        {
            return Datos.Cursado.GetOne(id);
        }

        public static List<Entidades.Cursado> BuscarCursadosPorCurso(int IdCurso)
            => GetAll().Where(c => c.Curso.Id == IdCurso).ToList();

        public static List<Entidades.Cursado> BuscarCursadosPorAlumno(int LegajoAlummno)
            => GetAll().Where(c => c.Usuario.Legajo == LegajoAlummno).OrderBy(c => c.FechaHoraInscripcion).ToList();
    }
}

