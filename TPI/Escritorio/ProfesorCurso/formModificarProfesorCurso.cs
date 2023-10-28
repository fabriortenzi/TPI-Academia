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

        private TPI.Entidades.ProfesorCurso profesorCurso;
        private TPI.Entidades.Curso Curso;
        public formModificarProfesorCurso(TPI.Entidades.ProfesorCurso profesor_curso)
        {
            profesorCurso = TPI.Negocio.ProfesorCurso.GetOne(profesor_curso.Id);
            Curso = TPI.Negocio.Curso.GetOne(profesor_curso.Curso.Id);

            profesorCurso = profesor_curso;
            InitializeComponent();



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string cargo = txtCargo.Text;
            //Hay que validar el cargo?
            TPI.Negocio.ProfesorCurso.Cambiar(profesorCurso, cargo, profesorCurso.Usuario, profesorCurso.Curso);
            MessageBox.Show($"Cargo: {cargo} modificado y agregado con exito");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formModificarProfesorCurso_Load(object sender, EventArgs e)
        {
            lblCurso.Text = profesorCurso.Curso.Id.ToString();
            lblLegajo.Text = profesorCurso.Usuario.Legajo.ToString();
            lblAnio.Text = Curso.CicloLectivo.ToString();
            txtCargo.Text = profesorCurso.Cargo;
            lblEsp.Text = Curso.Comision.Especialidad.Descripcion;
            lblPlan.Text = Curso.Materia.Plan.Anio.ToString();
            lblMateria.Text = Curso.Materia.Descripcion;
            lblCom.Text = Curso.Comision.NroComision.ToString();
        }
    }
}
