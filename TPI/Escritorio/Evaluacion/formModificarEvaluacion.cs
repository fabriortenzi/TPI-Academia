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
    public partial class formModificarEvaluacion : Form
    {
        private TPI.Entidades.Evaluacion? Evaluacion;
        public formModificarEvaluacion(TPI.Entidades.Evaluacion evaluacion)
        {
            InitializeComponent();

            lblLegajo.Text = evaluacion.LegajoUsuario.ToString();
            lblEvaluacion.Text = evaluacion.idEvaluacion.ToString();
            lblFecha_hora.Text = evaluacion.FechaHora.ToString();
            Evaluacion = evaluacion;
        }
       

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            Evaluacion.Nota = (int)nudNota.Value;
            TPI.Negocio.Evaluaciones.Cambiar(Evaluacion, Evaluacion.Nota);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
