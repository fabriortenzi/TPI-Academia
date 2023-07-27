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

            try
            {
                int dni = Convert.ToInt32(this.txtDni.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                string direccion = this.txtDireccion.Text;
                int dia = Convert.ToInt32(this.txtDia.Text);
                int mes = Convert.ToInt32(this.txtMes.Text);
                int año = Convert.ToInt32(this.txtAño.Text);
                string telefono = this.txtTelefono.Text;

                var persona = TPI.Negocio.Persona.CrearPersona(dni, nombre, apellido, direccion, new DateTime(año, mes, dia), telefono);

                TPI.Negocio.Persona.AgregarPersona(persona);

                MessageBox.Show("Persona creada con exito!");

                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Algunos campos son incorrectos o quedaron en blanco");
            }
        }
    }
}
