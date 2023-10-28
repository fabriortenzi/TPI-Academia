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
        private TPI.Entidades.ProfesorCurso profesorCurso;
        private TPI.Entidades.Curso Curso;
        private TPI.Entidades.Usuario profesor;
        public formMostrarProfesorCurso(TPI.Entidades.ProfesorCurso profesor_curso)
        {
            InitializeComponent();
            profesorCurso = TPI.Negocio.ProfesorCurso.GetOne(profesor_curso.Id);
            Curso = TPI.Negocio.Curso.GetOne(profesor_curso.Curso.Id);
            profesor = TPI.Negocio.Usuario.GetOne(profesor_curso.Usuario.Legajo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (profesorCurso != null)
            {
                formModificarProfesorCurso formModificarProfesorCurso = new formModificarProfesorCurso(profesorCurso);
                formModificarProfesorCurso.Show();
            }
            else { MessageBox.Show("Error"); }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMostrarProfesorCurso_Load(object sender, EventArgs e)
        {

            lblCurso.Text = profesorCurso.Curso.Id.ToString();
            lblLegajo.Text = profesorCurso.Usuario.Legajo.ToString();
            lblAnio.Text = Curso.CicloLectivo.ToString();
            lblCargo.Text = profesorCurso.Cargo;
            lblEsp.Text = Curso.Comision.Especialidad.Descripcion;
            lblPlan.Text = Curso.Materia.Plan.Anio.ToString();
            lblMateria.Text = Curso.Materia.Descripcion;
            lblCom.Text = Curso.Comision.NroComision.ToString();
            lblProfesor.Text = $"{profesor.Persona.Nombre} {profesor.Persona.Apellido}";
        }
    }
}
