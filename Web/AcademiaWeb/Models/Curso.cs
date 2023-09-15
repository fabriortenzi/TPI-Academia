using System.ComponentModel.DataAnnotations;
using System;

namespace AcademiaWeb.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        public int CicloLectivo { get; set; }

        public Materia Materia { get; set; }

        public Comision Comision { get; set; }

        public int Cupo { get; set; }

        public string Dia { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }
    }

}


   