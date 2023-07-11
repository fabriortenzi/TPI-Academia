using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.CRUD.Usuario
{
    public partial class updateUsuario : Form
    {
        public updateUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int legajo = Convert.ToInt32(this.txtLegajo.Text);
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;

            TPI.Entidades.Usuario usuario = TPI.Negocio.Usuario.GetUsuarioPorNombreApellido(nombre, apellido);

            dgvUsuario.DataSource = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo;
                if (this.txtLegajo.Text == "")
                    legajo = 0;
                else
                    legajo = Convert.ToInt32(this.txtLegajo.Text);

                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;

                TPI.Entidades.Usuario usuario = TPI.Negocio.Usuario.GetUsuarioPorNombreApellido(nombre, apellido);

                List<TPI.Entidades.Usuario> usuarioLista = new() { usuario };

                dgvUsuario.DataSource = usuarioLista;
            }
            catch
            {
                MessageBox.Show("Algunos campos quedaron en blanco", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            modificarUsuario modificarUsuario = new();
            modificarUsuario.Show();
        }
    }
}
