using System.ComponentModel.DataAnnotations;
using System;

namespace AcademiaWeb.Models
{
   

        public class Especialidad
        {
            [Key]
            public int Id { get; set; }

            public string Descripcion { get; set; }

        }
    
}

