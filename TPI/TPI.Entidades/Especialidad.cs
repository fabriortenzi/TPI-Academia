using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Especialidad
    {
        [Key]
        public int Id { get; }

        public string Descripcion { get; set; }

        public Especialidad(string descripcion) 
        {
            Descripcion = descripcion;
        }
    }
}
