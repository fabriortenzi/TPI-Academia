using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Curso
{
    public partial class formMostrarCurso : Form
    {
        private TPI.Entidades.Curso curso;
        public formMostrarCurso(TPI.Entidades.Curso Curso)
        {
            curso = Curso;
            InitializeComponent();
        }

        private void formMostrarCurso_Load(object sender, EventArgs e)
        {

            if (curso != null && curso.CicloLectivo> 0 && curso.Materia != null && curso.Comision != null && curso.Cupo > 0)
            lblEspecialidad.Text = curso.Comision.Especialidad.Descripcion;
            lblPlan.Text = curso.Materia.Plan.Anio.ToString();
            lblCiclo.Text = curso.CicloLectivo.ToString();
            lblCupo.Text = curso.Cupo.ToString();
            lblComision.Text = curso.Comision.NroComision.ToString();
            lblDia.Text = curso.Dia;
            lblHoraIni.Text = curso.HoraInicio.ToString();
            lblHoraFin.Text = curso.HoraFin.ToString();
            if (curso == null) { MessageBox.Show("El curso no existe"); }
            if (curso.CicloLectivo <= 0) { MessageBox.Show("Año incorrecto"); }
            if (curso.Cupo <= 0) { MessageBox.Show("Cupo incorrecto"); }
            if (curso.Materia == null || curso.Comision == null) { MessageBox.Show("El curso no posee o Materia o comision, verificar migraciones o base de datos"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
