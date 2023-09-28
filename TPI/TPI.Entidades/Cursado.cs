using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Cursado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public Usuario Usuario { get; set; }

        public Curso Curso { get; set;}

        public DateTime FechaHoraInscripcion { get; set; }

        public int NotaFinal { get; set; }

        public Cursado(Usuario usuario, Curso curso, DateTime fechaHoraInscripcion, int notaFinal)
        {
            Usuario = usuario;
            Curso = curso;
            FechaHoraInscripcion = fechaHoraInscripcion;
            NotaFinal = notaFinal;
        }
    }
}
