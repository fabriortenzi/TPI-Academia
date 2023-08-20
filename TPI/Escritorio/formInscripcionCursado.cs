using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Entidades;

namespace Escritorio
{
    public partial class formInscripcionCursado : Form
    {
        private TPI.Entidades.Usuario Usuario;

        // private TPI.Entidades.MateriaComision MateriaComision;

        private TPI.Entidades.Curso Curso;

        private List<TPI.Entidades.Curso> CursosMateria;

        public formInscripcionCursado(TPI.Entidades.Usuario usuario)
        {
            Usuario = usuario;
        }

        private void formInscripcionCursado_Load(object sender, EventArgs e)
        {
            var cursosMateria = TPI.Negocio.Curso.GetCursosPorPlanYAñoActual(Usuario.Plan);
            CursosMateria = cursosMateria;

            foreach (TPI.Entidades.Curso curso in cursosMateria)
            {
                cbxCursosMateria.Items.Add(curso.Materia.descMateria);
            }

        }

        private void cbxCursosMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var materiaSeleccionada = cbxCursosMateria.SelectedIndex.ToString();
            Curso = CursosMateria.FirstOrDefault(cm => cm.Materia.descMateria == materiaSeleccionada);

            // Cargar las comisiones disponibles
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string horario = $"{MateriaComision.Dia} de {MateriaComision.HoraInicio} a {MateriaComision.HoraFin}"
            // lblHorarioCurso.Text = horario;
            lblHorarioCurso.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // if (TPI.Negocio.InscripcionCursado.ValidarHorarioSuperpuesto(MateriaComision) == true)
            {
                // var inscripcion = TPI.Negocio.InscripcionCursado.CrearInscripcion(Curso, Usuario, MateriaComision.Comision);
            }
        }
    }
}
