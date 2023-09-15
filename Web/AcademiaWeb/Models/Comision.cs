using System.ComponentModel.DataAnnotations;

namespace AcademiaWeb.Models
{
    public class Comision
    {
        [Key]
        public int Id { get; set;}

        public int NroComision { get; set; }

        public Especialidad Especialidad { get; set; }
    }
}
