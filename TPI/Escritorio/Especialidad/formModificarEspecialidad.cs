using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Especialidad
{
    public partial class formModificarEspecialidad : Form
    {
        private TPI.Entidades.Especialidad Especialidad { get; set; }

        public formModificarEspecialidad()
        {
            InitializeComponent();
        }

        public void UpdateGrid()
        {
            dgvEspec.DataSource = TPI.Negocio.Especialidad.GetAllEspecialidades();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formModificarEspecialidad_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            btnModificar.Enabled = false;
        }

        private void dgvEspec_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEspec.ClearSelection();
        }

        private void dgvEspec_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEspec.SelectedRows.Count > 0)
            {
                string? descEsp = dgvEspec.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                Especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(descEsp);
                btnModificar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var f = new formCrearEspecialidad(Especialidad);
            f.Show();
            this.Close();
        }
    }
}
