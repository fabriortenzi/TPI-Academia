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
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        public Curso Curso { get; set; }

        public string Cargo { get; set; }

        
        public ProfesorCurso()
        { }

        public ProfesorCurso(Usuario usuario, Curso curso, string cargo)
        {
            Usuario = usuario;
            Curso = curso;
            Cargo = cargo;
        }
        public override string ToString()
        {
            return $"{Id}";

        }
    }
}
