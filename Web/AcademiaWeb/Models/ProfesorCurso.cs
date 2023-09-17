using System.ComponentModel.DataAnnotations;

namespace AcademiaWeb.Models
{
    public class ProfesorCurso
    {
        [Key]
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        public Curso Curso { get; set; }

        public string Cargo { get; set; }
    }
}
