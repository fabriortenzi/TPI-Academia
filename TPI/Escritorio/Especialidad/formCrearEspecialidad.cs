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
    public partial class formCrearEspecialidad : Form
    {
        private TPI.Entidades.Especialidad? Especialidad { get; set; }

        public formCrearEspecialidad(TPI.Entidades.Especialidad? _especialidad = null)
        {
            InitializeComponent();
            Especialidad = _especialidad;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            // Mofificar
            if (Especialidad != null)
            {
                Especialidad.Descripcion = txtDescripcion.Text;

                if (await TPI.Negocio.Especialidad.ModificarEspecialidad(Especialidad))
                {
                    MessageBox.Show("Especialidad modificada correctamenete");
                    Dispose();

                    var f = new formModificarEspecialidad();
                    f.Show();

                    return;
                }
                else
                {
                    MessageBox.Show("Error al modificar especialidad, intente con otro nombre");
                    return;
                }
            }

            // Crear
            string descripcion = txtDescripcion.Text;

            if (await TPI.Negocio.Especialidad.CrearEspecialidad(descripcion))
            {
                MessageBox.Show("Especialidad agregada exitosamente");
                Dispose();
            }
            else
            {
                MessageBox.Show("Error al agregar especialidad, intente con otro nombre");
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void formCrearEspecialidad_Load(object sender, EventArgs e)
        {
            if (Especialidad != null)
            {
                txtDescripcion.Text = Especialidad.Descripcion;
            }
        }
    }
}
