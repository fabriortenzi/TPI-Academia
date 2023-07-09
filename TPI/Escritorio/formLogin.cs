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
            // Inicializar Lista de Usuarios en la Capa Datos
            TPI.Datos.Usuario.InicializarLista();

            /*string usuario = this.txtUsuario.Text;
            string contraseña = this.txtPass.Text;*/

            TPI.Entidades.Usuario usuarioIngresado = TPI.Negocio.Usuario.GetUsuarioPorNombreUsuarioYContraseña("juangomez", "clave1");

            if (usuarioIngresado != null)
            {
                switch (usuarioIngresado.getTipo())
                {
                    case "Alumno":
                        // TODO
                        MessageBox.Show("Bienvenido Alumno/a");
                        break;
                    case "Profesor":
                        // TODO
                        MessageBox.Show("Bienvenido Profesor/a");
                        break;
                    case "Administrativo":
                        this.DialogResult = DialogResult.OK;
                        formAdministrativo appAdministrativo = new();
                        appAdministrativo.Show();
                        this.Hide();
                        break;
                }
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
