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
    public partial class formInscripcionCursado : Form
    {
        public formInscripcionCursado()
        {
            InitializeComponent();
        }

        private void formInscripcionCursado_Load(object sender, EventArgs e)
        {
            TPI.Datos.Especialidades.InicializarListaEspecialidades();
            TPI.Datos.Plan.InicializarListaPlanes();

            foreach (var especialidad in TPI.Datos.Especialidades.GetEspecialidades())
            {
                comboBoxEspecialidades.Items.Add(especialidad.descEspec);
            }
        }

        private void comboBoxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxEspecialidades.SelectedIndex != -1)
            {
                string especialidadSeleccionada = comboBoxEspecialidades.SelectedItem.ToString();

                MessageBox.Show($"Has seleccionado la especialidad: {especialidadSeleccionada}");

                // asigno la especialidad al usuario logueado

                // TPI.Datos.Usuario.AsignaEspecialidad(especialidadSeleccionada); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una especialidad.");
            }
        }
    }
}
