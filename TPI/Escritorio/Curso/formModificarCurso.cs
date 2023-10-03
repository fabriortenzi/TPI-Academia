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
    public partial class formModificarCurso : Form
    {
        private TPI.Entidades.Curso curso;
        public formModificarCurso(TPI.Entidades.Curso Curso)
        {
            curso = Curso;
            InitializeComponent();
        }

        private void formModificarCurso_Load(object sender, EventArgs e)
        {
            lblEspecialidad.Text = curso.Comision.Especialidad.Descripcion;
            lblPlan.Text = curso.Materia.Plan.Anio.ToString();
            lblMateria.Text = curso.Materia.Descripcion;
            lblComision.Text = curso.Comision.NroComision.ToString();
            txtAño.Text = curso.CicloLectivo.ToString();
            txtCupo.Text = curso.Cupo.ToString();
            txtDia.Text = curso.Dia;
            dtpHoraIni.Value = Convert.ToDateTime(curso.HoraInicio.ToString());
            dtpHoraFin.Value = Convert.ToDateTime(curso.HoraFin.ToString());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int año = 0, cupo = 0;
            string dia;
            TimeSpan hora_ini, hora_fin;
            try
            {
                año = Convert.ToInt32(txtAño.Text);
                cupo = Convert.ToInt32(txtCupo.Text);
                dia = txtDia.Text;
                hora_ini = dtpHoraIni.Value.TimeOfDay;
                hora_fin = dtpHoraFin.Value.TimeOfDay;

                TPI.Negocio.Curso.Cambiar(curso, año, curso.Materia, curso.Comision, cupo, dia, hora_ini, hora_fin);

            }
            catch 
            {
                MessageBox.Show("Error de ingreso");
            }
        }
    }
}
