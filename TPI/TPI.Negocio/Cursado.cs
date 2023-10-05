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
            if(nota>=0 && nota <= 10) { return true; }
            else { return false; }
        }
        public static Entidades.Cursado BuscarCursoPorUsuarioCurso(Entidades.Usuario usuario, Entidades.Curso curso) 
        {
            return Datos.Cursado.GetAll().FirstOrDefault(x => x.Usuario == usuario && x.Curso == curso);
        }
        public static List<Entidades.Cursado> BuscarCursadosPorUsuarioAño(Entidades.Usuario usuario, int ciclo)
        {
            return TPI.Datos.Cursado.GetAll().Where(x => x.Usuario == usuario && x.Curso.CicloLectivo == ciclo).ToList();
        }
        public static List<Entidades.Cursado> BuscarCursadosPorAño(int year) 
        {
            return TPI.Datos.Cursado.GetAll().Where(x => x.Usuario.Plan.Anio == year).ToList();
        }
        public static Entidades.Cursado Crear(Entidades.Usuario usuario, Entidades.Curso curso, DateTime fechaHoraInscripcion) 
        {
            return new Entidades.Cursado(usuario, curso, fechaHoraInscripcion);
        }
        public static void Agregar(Entidades.Cursado Cursado)
        => Datos.Cursado.Agregar(Cursado);

        public static void Eliminar(Entidades.Cursado Cursado)
        => Datos.Cursado.Eliminar(Cursado);
        public static void Cambiar(Entidades.Cursado cursado, Entidades.Usuario usuario, Entidades.Curso curso, DateTime fechahorains, int notafinal)
        {
            
            
                Datos.Cursado.Cambiar(cursado, usuario, curso, fechahorains, notafinal);
            
            

            }

        public static bool ValidarCurso(Entidades.Usuario us, Entidades.Curso curso) 
        {
            bool f1 = false;
            foreach(Entidades.Cursado cursado in BuscarCursadosPorUsuarioAño(us, curso.CicloLectivo)) 
            {
                //Evitando superposicion de cursos
                //               | --Curso a agregar---|
                // | -caso 1-- |                       | -caso 2-- |
                //1 y dos son condiciones que se pueden cumplir lo demas no es admisible
                if (cursado.Curso!=curso && ((cursado.Curso.HoraInicio<curso.HoraInicio && cursado.Curso.HoraFin <= curso.HoraInicio)||(cursado.Curso.HoraInicio>=curso.HoraFin && cursado.Curso.HoraFin>curso.HoraFin)))
                {
                    f1 = true;
                }
                else { f1 = false; }

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
    }
}

