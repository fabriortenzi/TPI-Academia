using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; }

        public int CicloLectivo { get; set; }

        public Materia Materia { get; set; }

        public Comision Comision { get; set; }

        public int Cupo { get; set; }

        public string Dia { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public Curso() { }

        public Curso(Materia materia, int cicloLectivo, Comision comision, int cupo, string dia, TimeSpan horaInicio, TimeSpan horaFin)
        {
            Materia = materia;
            CicloLectivo = cicloLectivo;
            Cupo = cupo;
            Dia = dia;
            Comision = comision;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }

        public override string ToString()
        {
            return Materia.Descripcion;
        }
    }
}
