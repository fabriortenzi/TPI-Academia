using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class formAgregoPlan : Form
    {
        public formAgregoPlan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void formAgregoPlan_Load(object sender, EventArgs e)
        {
            foreach (var especialidad in TPI.Datos.Especialidades.GetEspecialidades())
            {
                comboBoxEsp.Items.Add(especialidad.Descripcion);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string año;
            año = this.textBoxAño.Text;
            if (año.Length > 4)
            {
                MessageBox.Show("El Plan debe ser un Año valido de 4 digitos", "Agrego Plan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            try
            {
                Convert.ToInt32(año);
            }
            catch
            {
                MessageBox.Show("Ingrese el Año correctamente", "Agrego Plan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }


            string esp = this.comboBoxEsp.SelectedItem.ToString();

            TPI.Entidades.Especialidad especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(esp);

            var Plan = TPI.Negocio.Plan.CrearPlan(Convert.ToInt32(año), especialidad);

            if (await TPI.Negocio.Plan.AgregoPlan(Plan))
            {
                MessageBox.Show("Plan creado con exito!", "Agrego Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al crear el Plan, intente con otro Año", "Agrego Plan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEsp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
