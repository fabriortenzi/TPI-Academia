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
    public partial class formModificarProfesorCurso : Form
    {
        private TPI.Entidades.ProfesorCurso? profesorCurso;
        public formModificarProfesorCurso(TPI.Entidades.ProfesorCurso profesor_curso)
        {
            InitializeComponent();
            lblMateria.Text = profesor_curso.Curso.Materia.Descripcion;
            //lblLegajo.Text = profesor_curso.Legajo.ToString();
            //lblAnio.Text = profesor_curso.Anio.ToString();
            profesorCurso = profesor_curso;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string cargo = txtCargo.Text;
            TPI.Negocio.ProfesorCurso.Cambiar(profesorCurso, cargo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
