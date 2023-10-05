using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Comision
{
    public partial class formEliminarComision : Form
    {

        public TPI.Entidades.Especialidad esp { get; set; }
        public int nro_com { get; set; }

        public formEliminarComision()
        {
            InitializeComponent();
        }

        private void formEliminarComision_Load(object sender, EventArgs e)
        {
            foreach (var esp in TPI.Negocio.Especialidad.GetAllEspecialidades())
            {
                cbxEspecialidad.Items.Add(esp.Descripcion);
            }
        }

        private void cbxEspecialidad_StyleChanged(object sender, EventArgs e)
        {
            string desc_especialidad = cbxEspecialidad.SelectedItem.ToString();
            esp = TPI.Negocio.Especialidad.Getespecialidadpordesc(desc_especialidad);

            foreach (var com in TPI.Negocio.Comision.BuscarComisionesPorEspecialidad(esp))
            {
                cbxComision.Items.Add(com.NroComision);
            }
            cbxComision.Enabled = true;
        }

        private void cbxComision_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nro_com = int.Parse(cbxComision.SelectedItem.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar la comision?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario.
            if (resultado == DialogResult.Yes)
            {
                TPI.Entidades.Comision comision = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nro_com, esp);
                TPI.Negocio.Comision.Eliminar(comision);
                MessageBox.Show($"{comision.Especialidad.Descripcion + "" + comision.NroComision} borrada");
            }
            else
            {
            }
        }
    }
}
