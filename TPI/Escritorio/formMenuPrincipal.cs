using Escritorio.Comision;
using Escritorio.Inscripcion;
using Escritorio.ProfesorCurso;
using Escritorio.Generalizado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escritorio.Especialidad;
using Escritorio.Cursado;
using Escritorio.Curso;
using Escritorio.Reportes;

namespace Escritorio
{
    public partial class formMenuPrincipal : Form
    {
        private TPI.Entidades.Usuario Usuario;

        public formMenuPrincipal(TPI.Entidades.Usuario _usuario)
        {
            Usuario = _usuario;
            InitializeComponent();
        }

        private void formMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void crearPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNuevaPersona formNuevaPersona = new();
            formNuevaPersona.Show();
        }

        private void editarPersonaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formEditarPersona formEditarPersona = new(Usuario.Persona);
            formEditarPersona.Show();
        }

        private void nuevaInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInscripcionCursado formInscripcionCursado = new(Usuario);
            formInscripcionCursado.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNuevoUsuario formNuevoUsuario = new();
            formNuevoUsuario.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCambiarContraseña formCambiarContraseña = new(Usuario);
            formCambiarContraseña.Show();
        }

        private void consultarDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultarDatosUsuario formConsultarDatosUsuario = new(Usuario);
            formConsultarDatosUsuario.Show();
        }

        private void crearNuevaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCrearMateria formCrearMateria = new();
            formCrearMateria.Show();
        }

        private void crearNuevoPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAgregoPlan formAgregoPlan = new();
            formAgregoPlan.Show();
        }

        private void crearCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCrearCurso formCrearCurso = new();
            formCrearCurso.Show();
        }

        private void agregarEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eliminarEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formAgregarProfesorCurso formAgregarProfesorCurso = new();
            formAgregarProfesorCurso.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formEliminarProfesorCurso formEliminarProfesorCurso = new();
            formEliminarProfesorCurso.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formConsultarProfesorCurso formConsultarProfesorCurso = new();
            formConsultarProfesorCurso.Show();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
        }

        private void nuevaComisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCrearComision formCrearComision = new();
            formCrearComision.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.Persona));
            frmListar.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.Usuario));
            frmListar.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.Cursado));
            frmListar.Show();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.Materia));
            frmListar.Show();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.Comision));
            frmListar.Show();
        }

        private void listarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.Curso));
            frmListar.Show();
        }

        private void listarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.Plan));
            frmListar.Show();
        }

        private void listarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //formListar frmListar = new formListar(typeof(TPI.Entidades.Evaluacion));
            //frmListar.Show();
        }

        private void listarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //formListar frmListar = new formListar(typeof(TPI.Entidades.MateriaAprobada));
            //frmListar.Show();
        }

        private void listarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //formListar frmListar = new formListar(typeof(TPI.Entidades.MateriaComision));
            //frmListar.Show();
        }

        private void listarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.ProfesorCurso));
            frmListar.Show();
        }

        private void eliminarInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEliminarInscripcion formEliminarInscripcion = new(Usuario);
            formEliminarInscripcion.Show();
        }

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Deshabilito los menus segun el tipo de Usuario que ingreso

            if (Usuario.TipoDeUsuario.Descripcion != "Admin")
            {
                crearPersonaToolStripMenuItem.Visible = false;
                crearUsuarioToolStripMenuItem.Visible = false;
                listarPerToolStripMenuItem.Visible = false;
                especialidadToolStripMenuItem.Visible = false;
                listarPerToolStripMenuItem.Visible = false;
                listarUsuToolStripMenuItem1.Visible = false;
                comisionToolStripMenuItem.Visible = false;
                crearCursoToolStripMenuItem.Visible = false;
                listarToolStripMenuItem5.Visible = false;
                listarToolStripMenuItem2.Visible = false;
                planDeEstudioToolStripMenuItem.Visible = false;
                materiaToolStripMenuItem.Visible = false;
                profesorCursoToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
            }

            if (Usuario.TipoDeUsuario.Descripcion != "Alumno")
            {
                consultarDatosPersonalesToolStripMenuItem.Visible = false;
                nuevaInscripcionToolStripMenuItem.Visible = false;
                eliminarInscripcionToolStripMenuItem.Visible = false;
                consultarNotasToolStripMenuItem.Visible = false;
            }

            if (Usuario.TipoDeUsuario.Descripcion != "Profesor")
            {
                cargarNotaToolStripMenuItem.Visible = false;
                misCursosToolStripMenuItem.Visible = false;
            }

            if (Usuario.TipoDeUsuario.Descripcion == "Alumno")
            {
                cursoToolStripMenuItem.Visible = false;
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCrearEspecialidad f = new formCrearEspecialidad();
            f.Show();
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formModificarEspecialidad f = new formModificarEspecialidad();
            f.Show();
        }

        private void cargarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCargarNotas formCargarNotas = new(Usuario);
            formCargarNotas.Show();
        }

        private void consultarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultarNotas formConsultarNotas = new(Usuario);
            formConsultarNotas.Show();
        }

        private void misCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCursosProfesor formCursosProfesor = new(Usuario);
            formCursosProfesor.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReporteCurso formReporteCurso = new();
            formReporteCurso.Show();
        }

        private void listarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formListar frmListar = new formListar(typeof(TPI.Entidades.Especialidad));
            frmListar.Show();
        }
    }
}
