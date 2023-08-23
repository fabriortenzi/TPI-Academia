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
    public partial class formEliminarEvaluacion : Form
    {
        public formEliminarEvaluacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf == DialogResult.Yes)
            {
            
            
          
                int id_evaluacion = int.Parse(txtIdEvaluacion.Text);
            TPI.Entidades.Evaluacion evaluacion = TPI.Negocio.Evaluaciones.GetEvaluacion(id_evaluacion);
            }
            else { this.Close(); }
        }
    }
}
