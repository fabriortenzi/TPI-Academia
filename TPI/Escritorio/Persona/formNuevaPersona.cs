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
    public partial class formNuevaPersona : Form
    {
        public formNuevaPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string dia = txtDia.Text;
            string mes = txtMes.Text;
            string anio = txtAño.Text;

            try
            {
                TPI.Negocio.Persona.ValidarDatos(dni, nombre, apellido, direccion, telefono, dia, mes, anio);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Nueva Persona", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            var persona = TPI.Negocio.Persona.CrearPersona(
                Convert.ToInt32(dni), nombre, apellido, direccion,
                new DateTime(Convert.ToInt32(anio), Convert.ToInt32(mes), Convert.ToInt32(dia))
                , telefono);

            TPI.Negocio.Persona.AgregarPersona(persona);

            MessageBox.Show("Persona creada con exito!", "Nueva Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
