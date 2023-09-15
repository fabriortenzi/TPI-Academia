using System.ComponentModel.DataAnnotations;
using System;

namespace AcademiaWeb.Models
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        public Plan Plan { get; set; }

        public string Descripcion { get; }

        public int HorasSemanales { get; set; }

        public int HorasTotales { get; set; }


     
        
    }

    }

