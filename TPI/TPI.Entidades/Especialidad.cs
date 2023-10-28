using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Especialidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; }

        public string Descripcion { get; set; }

        public Especialidad(string descripcion) 
        {
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return $"{Descripcion}";

        }
    }
}
