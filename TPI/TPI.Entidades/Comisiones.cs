using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Comisiones
    {
        [Key]
        public int IdCom { get; set; }

        [Key]
        public int IdEspecialidad { get; set; }

        [ForeignKey("IdEspecialidad")]
        public Especialidad Especialidad { get; private set; }

        public Comisiones() { }

        public Comisiones (int id_com, Especialidad especialidad)
        {
            IdCom = id_com;
            Especialidad = especialidad;
        }
    }
}
