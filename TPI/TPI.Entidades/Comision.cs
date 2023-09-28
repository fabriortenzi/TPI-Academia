using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Comision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int NroComision { get; set; }

        public Especialidad Especialidad { get; set; }

        public Comision() { }

        public Comision (int nroComision, Especialidad especialidad)
        {
            NroComision = nroComision;
            Especialidad = especialidad;
        }
    }
}
