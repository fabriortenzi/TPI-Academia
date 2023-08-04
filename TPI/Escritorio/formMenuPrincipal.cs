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
        private TPI.Entidades.Usuario Usuario;

        public formMenuPrincipal(TPI.Entidades.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        private void formMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TPI.Datos.Usuario.InicializarListaUsuarios();
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
            formEditarPersona formEditarPersona = new(Usuario.Persona);
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

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Inicializar Listas en la Capa Datos
            TPI.Datos.Modulo.InicializarListaModulos();
            TPI.Datos.ModuloUsuario.InicializarListaModulosUsuarios();


            // Opcion del Menu: Persona
            TPI.Entidades.Modulo moduloPersona = TPI.Negocio.Modulo.GetModuloPersona();
            TPI.Entidades.ModuloUsuario moduloUsuarioPersona = TPI.Negocio.ModuloUsuario.GetModuloUsuario(moduloPersona, Usuario.TipoDeUsuario);

            nuevaMenuItemPersona.Visible = moduloUsuarioPersona.Alta;
            editarMenuItemPersona.Visible = moduloUsuarioPersona.Modificacion;


            // Opcion del Menu: Usuario
            TPI.Entidades.Modulo moduloUsuario = TPI.Negocio.Modulo.GetModuloUsuario();
            TPI.Entidades.ModuloUsuario moduloUsuarioUsuario = TPI.Negocio.ModuloUsuario.GetModuloUsuario(moduloUsuario, Usuario.TipoDeUsuario);

            nuevoMenuItemUsuario.Visible = moduloUsuarioUsuario.Alta;
            consultarDatosMenuItemUsuario.Visible = moduloUsuarioUsuario.Consulta;
            cambiarContraseñaMenuItemUsuario.Visible = moduloUsuarioUsuario.Modificacion;
        }

        private void formMenuPrincipal_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void nuevaMenuItemPersona_Click(object sender, EventArgs e)
        {
            formNuevoUsuario formNuevoUsuario = new();
            formNuevoUsuario.Show();
        }

        private void consultarDatosMenuItemUsuario_Click(object sender, EventArgs e)
        {
            formConsultarDatosUsuario formConsultarDatosUsuario = new(Usuario);
            formConsultarDatosUsuario.Show();
        }

        private void cambiarContraseñaMenuItemUsuario_Click(object sender, EventArgs e)
        {
            formCambiarContraseña formCambiarContraseña = new(Usuario);
            formCambiarContraseña.Show();
        }
    }
}

