using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.ProfesorCurso
{
    public partial class formMostrarProfesorCurso : Form
    {
        private TPI.Entidades.ProfesorCurso? profesorCurso;
        public formMostrarProfesorCurso(TPI.Entidades.ProfesorCurso profesor_curso)
        {
            profesorCurso = profesor_curso;
            InitializeComponent();
            lblCurso.Text = profesor_curso.Curso.Id.ToString();
            lblLegajo.Text = profesor_curso.Usuario.Legajo.ToString();
            lblAnio.Text = profesor_curso.Curso.CicloLectivo.ToString();
            lblCargo.Text = profesor_curso.Cargo;
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (profesorCurso != null) {
                formModificarProfesorCurso formModificarProfesorCurso = new formModificarProfesorCurso(profesorCurso);
            formModificarProfesorCurso.Show();
            }
            else { MessageBox.Show("Error"); }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
