using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Plan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; }

        public int Anio { get; set; }

        public Especialidad Especialidad { get; set; }

        public Plan() { }

        public Plan (int anioP, Especialidad especialidad)
        {
            Anio = anioP;
            Especialidad = especialidad;
        }
        public override string ToString()
        {
            if (Anio != null) { return $"{Anio}";}
            else { return "No posee"; }
        }
    }
}
