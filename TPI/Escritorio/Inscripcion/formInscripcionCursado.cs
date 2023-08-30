using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Inscripcion
{
    public partial class formInscripcionCursado : Form
    {
        private TPI.Entidades.Usuario Usuario;

        private TPI.Entidades.MateriaComision MateriaComision;

        private TPI.Entidades.Curso Curso;

        private List<TPI.Entidades.Curso> CursosMateria;

        public formInscripcionCursado(TPI.Entidades.Usuario usuario)
        {
            Usuario = usuario;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
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

        private void cbxComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string horario = $"{MateriaComision.dia} de {MateriaComision.hora_ini} a {MateriaComision.hora_fin}";
            lblHorarioCurso.Text = horario;
            lblHorarioCurso.Visible = true;
        }
    }
}
