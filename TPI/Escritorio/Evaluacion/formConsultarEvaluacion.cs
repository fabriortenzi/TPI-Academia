using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Evaluacion
{
    public partial class formConsultarEvaluacion : Form
    {
        public formConsultarEvaluacion()
        {
            InitializeComponent();
            cargar_cbxEvaluacion();
        }

        private void cargar_cbxEvaluacion()
        {
            List<TPI.Entidades.Evaluacion> evaluaciones = TPI.Negocio.Evaluaciones.GetAllEvaluacion();
            foreach (TPI.Entidades.Evaluacion ev in evaluaciones) { cbxEvaluacion.Items.Add(ev.Id); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int id_evaluacion = int.Parse(cbxEvaluacion.GetItemText(cbxEvaluacion.SelectedItem));
            TPI.Entidades.Evaluacion evaluacion = TPI.Negocio.Evaluaciones.GetEvaluacion(id_evaluacion);
            formMostrarEvaluacion frmMostrarEvaluacion = new formMostrarEvaluacion(evaluacion);
            frmMostrarEvaluacion.Show();
        }
    }
}
