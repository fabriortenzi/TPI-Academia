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
            InitializeComponent();
            lblMateria.Text = profesor_curso.Curso.Materia.Descripcion;
            //lblLegajo.Text = profesor_curso.Legajo.ToString();
            //lblAnio.Text = profesor_curso.Anio.ToString();
            lblCargo.Text = profesor_curso.Cargo;
            profesorCurso = profesor_curso;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
