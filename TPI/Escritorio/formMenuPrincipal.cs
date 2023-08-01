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
            TPI.Datos.Usuario.InicializarListaUsarios();
            TPI.Datos.Persona.InicializarListaPersonas();
            TPI.Datos.TipoDeUsuario.InicializarTiposDeUsuario();
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNuevoUsuario formNuevoUsuario = new();
            formNuevoUsuario.Show();
        }

        private void inscripcionACursadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInscripcionCursado formInscripcionCursado = new();
            formInscripcionCursado.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formAgregoPlan formAgregoPlan = new();
            formAgregoPlan.Show();
        }

        private void nuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formCrearMateria formCrearMateria = new();
            formCrearMateria.Show();
        }
    }
}

