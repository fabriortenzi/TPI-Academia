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
        [Column(Order = 1)]
        public int LegajoUsuario { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FechaHora { get; private set; }

        [ForeignKey("LegajoUsuario")]
        public Usuario Usuario { get; private set; }

        public int IdMateria { get; set; }

        public int AñoCurso { get; set; }

        [ForeignKey("IdMateria, AñoCurso")]
        public Curso Curso { get; private set; }

        public int IdComision { get; set; }

        public int IdEspecialidad { get; set; }

        [ForeignKey("IdComision, IdEspecialidad")]
        public Comisiones Comision { get; private set; }

        public InscripcionCursado() { }

        public InscripcionCursado(Curso curso, Usuario usuario, Comisiones comision, DateTime fechaHora)
        {
            Curso = curso;
            Usuario = usuario;
            Comision = comision;
            FechaHora = fechaHora;
        }
    }
}
