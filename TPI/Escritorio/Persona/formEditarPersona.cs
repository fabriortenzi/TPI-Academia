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
        private TPI.Entidades.Persona Persona;
        private string direccionOriginal;
        private string telefonoOriginal;
        private string direccionCambiada;
        private string telefonoCambiado;

        public formEditarPersona(TPI.Entidades.Persona persona)
        {
            InitializeComponent();
            Persona = persona;
        }

        private void formEditarPersona_Load(object sender, EventArgs e)
        {
            lblNomApe.Text = $"{Persona.Apellido}, {Persona.Nombre}";
            direccionOriginal = Persona.Direccion;
            telefonoOriginal = Persona.Telefono;
            txtDireccion.Text = direccionOriginal;
            txtTelefono.Text = telefonoOriginal;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            direccionCambiada = txtDireccion.Text;

            if (direccionOriginal != direccionCambiada)
            {
                btnEditar.Enabled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            telefonoCambiado = txtTelefono.Text;

            if (telefonoOriginal != telefonoCambiado)
            {
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TPI.Negocio.Persona.EditarDatosPersona(Persona, direccionCambiada, telefonoCambiado);
            MessageBox.Show("Datos modificados exitosamente!");
            this.Close();
        }
    }
}
