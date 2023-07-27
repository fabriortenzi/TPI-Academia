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
<<<<<<< Updated upstream
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TPI.Datos.Usuario.InicializarListaUsarios();
            TPI.Datos.Persona.InicializarListaPersonas();
            TPI.Datos.TipoDeUsuario.InicializarTiposDeUsuario();

            // if (tipoUsuario.Descripcion == "alumno") me lleva a error pq considera que tipoUsuario es Null
            if (tipoUsuario == TPI.Datos.TipoDeUsuario.GetTipoAlumno()) // asi me lleva siempre al else
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
=======
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNuevaPersona formNuevaPersona = new();
            formNuevaPersona.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEditarPersona formEditarPersona = new();
            formEditarPersona.Show();
        }
>>>>>>> Stashed changes
    }
}
