using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        public Plan Plan { get; set; }

        public string Descripcion { get; set; }

        public int HorasSemanales { get; set; }

        public int HorasTotales { get; set; }

        public Materia() { }

        public Materia (string desc, int hora_sem, int hora_tot, Plan plan)
        {
            Descripcion = desc;
            HorasSemanales = hora_sem;
            HorasTotales = hora_tot;
            Plan = plan;
        }
    }
}
