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
    public partial class formCambiarContraseña : Form
    {
        private TPI.Entidades.Usuario Usuario;

        public formCambiarContraseña(TPI.Entidades.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string cont = txtCnt.Text;
            string nuevCont = txtNuevCont.Text;
            string confCont = txtConf.Text;

            if (cont != Usuario.Contraseña)
            {
                MessageBox.Show("Contraseña actual incorrecta");
            }
            else if (nuevCont == "" || confCont == "")
            {
                MessageBox.Show("Ingrese una nueva contraseña");
            }
            else if (nuevCont == confCont)
            {
                TPI.Negocio.Usuario.CambiarContraseña(Usuario, nuevCont);
                MessageBox.Show("Contraseña modificada exitosamente!");
                Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden");
            }
        }
    }
}
