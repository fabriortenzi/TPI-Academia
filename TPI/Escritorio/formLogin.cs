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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int legajo = Convert.ToInt32(this.txtUsuario.Text);
            string contraseña = this.txtPass.Text;

            TPI.Entidades.Usuario usuario = TPI.Negocio.Usuario.GetUsuarioPorLegajoYContraseña(legajo, contraseña);

            if (usuario != null)
            {
                this.DialogResult = DialogResult.OK;
                formMenuPrincipal menuPrincipal = new formMenuPrincipal(usuario);
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de Usuario o Contrseña incorrectos");
            }
        }

        private void formLogin_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            appLogin.ShowDialog();
        }
    }
}
