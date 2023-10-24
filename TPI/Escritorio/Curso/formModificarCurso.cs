using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Datos;

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


                if(curso !=null && año>0 && curso.Materia!=null && curso.Comision !=null && cupo > 0) {
                    curso.Dia = dia;
                    curso.CicloLectivo = año;
                    curso.HoraInicio = hora_ini;
                    curso.HoraFin = hora_fin;
                    curso.Cupo = cupo;
                    TPI.Negocio.Curso.Cambiar(curso);
                }
                if(curso == null) { MessageBox.Show("El curso no existe"); }
                if (año <=0) { MessageBox.Show("Año incorrecto"); }
                if (cupo <= 0) { MessageBox.Show("Cupo incorrecto"); }
                if (curso.Materia == null || curso.Comision == null) { MessageBox.Show("El curso no posee o Materia o comision"); }

            }
            catch 
            {
                MessageBox.Show("Error de ingreso");
            }
        }
    }
}
