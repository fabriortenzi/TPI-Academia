using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Cursado
    {
        [Key]
        public int Id { get; set; }
        
        public Usuario Usuario { get; set; }

        public Curso Curso { get; set;}

        public DateTime FechaHoraInscripcion { get; set; }

        [AllowNull]
        public int? NotaFinal { get; set; }

        public Cursado()
        { }

        public Cursado(Usuario usuario, Curso curso, DateTime fechaHoraInscripcion)
        {
            Usuario = usuario;
            Curso = curso;
            FechaHoraInscripcion = fechaHoraInscripcion;            
        }

        public Cursado(Usuario usuario, Curso curso, DateTime fechaHoraInscripcion, int notaFinal)
        {
            Usuario = usuario;
            Curso = curso;
            FechaHoraInscripcion = fechaHoraInscripcion;
            NotaFinal = notaFinal;
        }
        public override string ToString()
        {
            return $"{Id}"; 
            
        }
    }
}
