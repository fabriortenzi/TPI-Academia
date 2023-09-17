using System.ComponentModel.DataAnnotations;

namespace AcademiaWeb.Models
{
    public class Plan
    {
        [Key]
        public int Id { get; set; }

        public int Anio { get; set; }

        //public Especialidad Especialidad { get; set; }
    }
}
