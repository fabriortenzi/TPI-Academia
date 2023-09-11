using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class InscripcionCursado
    {
        [Key]
        public int Id { get; }

        public DateTime FechaHora { get; private set; }

        public int LegajoUsuario { get; }

        [ForeignKey("LegajoUsuario")]
        public Usuario Usuario { get; private set; }

        public int IdMateria { get; }

        public int AñoCurso { get; }

        [ForeignKey("IdMateria, AñoCurso")]
        public Curso Curso { get; private set; }

        public int IdComision { get; }

        public int IdEspecialidad { get; }

        [ForeignKey("IdComision, IdEspecialidad")]
        public Comisiones Comision { get; private set; }

        public InscripcionCursado() { }

        public InscripcionCursado(Curso curso, Usuario usuario, Comisiones comision)
        {
            Curso = curso;
            Usuario = usuario;
            Comision = comision;
            FechaHora = DateTime.Now;
        }
    }
}
