using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Datos;

namespace Escritorio
{
    public partial class formMenuPrincipal : Form
    {
        private TPI.Entidades.TipoDeUsuario tipoUsuario;
        public formMenuPrincipal(TPI.Entidades.TipoDeUsuario tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
        }

        private void formMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TPI.Datos.TipoDeUsuario.InicializarTiposDeUsuario();


            if (tipoUsuario == TPI.Datos.TipoDeUsuario.GetTipoAlumno())
            {
                formMenuInscripcion menuInscripcion = new();
                menuInscripcion.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Solo los usuarios de tipo  alumnos pueden inscribirse");
            }
        }
    }
}
