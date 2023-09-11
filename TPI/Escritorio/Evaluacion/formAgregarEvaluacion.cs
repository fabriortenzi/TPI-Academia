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
    public partial class formAgregarEvaluacion : Form
    {
        public formAgregarEvaluacion()
        {
            InitializeComponent();
            cargar_cbxLegajo();
        }

        private void cargar_cbxLegajo() 
        {
            List<TPI.Entidades.Usuario> alumnos = TPI.Negocio.Usuario.GetAllAlumnos();

            foreach(TPI.Entidades.Usuario alu in alumnos) { cbxLegajo.Items.Add(alu.Legajo); }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TPI.Entidades.Evaluacion evaluacion = new TPI.Entidades.Evaluacion();
            
            int legajo = int.Parse(this.cbxLegajo.GetItemText(this.cbxLegajo.SelectedItem));
            //evaluacion.LegajoUsuario = legajo;
            //evaluacion.FechaHora = (DateTime)dtpFecha_hora.Value;
            evaluacion.Nota = (int)nudNota.Value;
            TPI.Negocio.Evaluaciones.Agregar(evaluacion);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
