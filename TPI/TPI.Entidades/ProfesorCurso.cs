using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class ProfesorCurso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Usuario Usuario { get; set; }

        public Curso Curso { get; set; }

        public string Cargo { get; set; }

        public ProfesorCurso(Usuario usuario, Curso curso, string cargo)
        {
            Usuario = usuario;
            Curso = curso;
            Cargo = cargo;
        }
    }
}
