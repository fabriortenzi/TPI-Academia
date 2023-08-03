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

                // asigno la especialidad al usuario del cual se ingreso el dni en el TXTALUMNO.

                // TPI.Datos.Usuario.AsignaEspecialidad(especialidadSeleccionada); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una especialidad.");
            }
        }

        private void txtAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(this.txtAlumno.Text);
                TPI.Entidades.Persona persona = TPI.Negocio.Persona.GetPersonaPorDni(dni);

                if(persona != null)
                {
                    lblAlumno.Text = persona.Apellido + persona.Nombre;
                }
                else
                {
                    MessageBox.Show("No existe una persona registrada con ese DNI");
                }
                
            }
            catch { MessageBox.Show("No existe una persona registrada con ese DNI"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAlumno_Click(object sender, EventArgs e)
        {

        }
    }
}
