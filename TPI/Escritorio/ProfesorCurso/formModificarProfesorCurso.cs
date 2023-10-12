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
            profesorCurso = profesor_curso;
            InitializeComponent();
            lblCurso.Text = profesor_curso.Curso.Id.ToString();
            lblLegajo.Text = profesor_curso.Usuario.Legajo.ToString();
            lblAnio.Text = profesor_curso.Curso.CicloLectivo.ToString();
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string cargo = txtCargo.Text;
            //Hay que validar el cargo?
            TPI.Negocio.ProfesorCurso.Cambiar(profesorCurso, cargo, profesorCurso.Usuario, profesorCurso.Curso);
            MessageBox.Show($"Cargo: {cargo} modificado y agregado con exito");
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
