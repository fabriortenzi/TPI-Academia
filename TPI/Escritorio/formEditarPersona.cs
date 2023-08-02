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
    public partial class formEditarPersona : Form
    {
        public formEditarPersona()
        {
            InitializeComponent();
        }

        private TPI.Entidades.Persona? personaIngresada;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(this.txtDni.Text);
                TPI.Entidades.Persona persona = TPI.Negocio.Persona.GetPersonaPorDni(dni);

                if (persona != null)
                {
                    string apellidoNombre = persona.Apellido + " " + persona.Nombre;

                    lblTitNomApe.Visible = true;
                    lblTitNomApe.Visible = true;
                    lblApeNomPersona.Visible = true;
                    lblApeNomPersona.Text = apellidoNombre;
                    btnEliminar.Enabled = true;
                    btnEditarDatos.Enabled = true;

                    personaIngresada = persona;
                }
                else
                {
                    MessageBox.Show("No hay una persona con ese DNI registrada");
                }
            }
            catch
            {
                MessageBox.Show("No hay una persona con ese DNI registrada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TPI.Negocio.Persona.EliminarPersona(personaIngresada);
            MessageBox.Show("Persona Eliminada con exito");
            this.Dispose();
        }
    }
}
