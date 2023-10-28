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
            int dni = 0, dia = 0, mes = 0, año = 0;

            try
            {
                dni = Convert.ToInt32(this.txtDni.Text);
                dia = Convert.ToInt32(this.txtDia.Text);
                mes = Convert.ToInt32(this.txtMes.Text);
                año = Convert.ToInt32(this.txtAño.Text);
            }
            catch
            {
                MessageBox.Show("Algunos campos son incorrectos o quedaron en blanco");
                return;
            }

            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;

            // Valida que ningun campo haya quedado en blanco
            if (dni != 0 && dia != 0 && mes != 0 && año != 0 && nombre != "" && apellido != "" & direccion != "" & telefono != "")
            {
                var persona = TPI.Negocio.Persona.CrearPersona(dni, nombre, apellido, direccion, new DateTime(año, mes, dia), telefono);

                TPI.Negocio.Persona.AgregarPersona(persona);

                MessageBox.Show("Persona creada con exito!");

               this.Close();
            }
            else
            {
                MessageBox.Show("Algunos campos quedaron en blanco");
            }
        }
    }
}
