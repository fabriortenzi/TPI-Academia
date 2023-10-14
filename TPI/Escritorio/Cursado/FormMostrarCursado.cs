using Escritorio.Cursado;
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

namespace Escritorio.Inscripcion
{
    public partial class FormMostrarCursado : Form
    {
        private TPI.Entidades.Cursado Cursado;
        private TPI.Entidades.Usuario usuario;
        public FormMostrarCursado(TPI.Entidades.Cursado cursado)
        {
            Cursado = cursado;
            usuario = TPI.Negocio.Usuario.GetOne(cursado.Usuario.Legajo);
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formModificarCursado formModificarCursado = new formModificarCursado(Cursado);
            formModificarCursado.Show();
        }

        private void FormMostrarCursado_Load(object sender, EventArgs e)
        {
            lblAño.Text = Cursado.Curso.CicloLectivo.ToString();


            lblUsuario.Text = (usuario.Persona.Nombre + " " + usuario.Persona.Apellido);
            lblCurso.Text = Cursado.Curso.Id.ToString();
            lblFecha.Text = Cursado.FechaHoraInscripcion.ToString();
            if (Cursado.NotaFinal != null)
            {
                lblNota.Text = Cursado.NotaFinal.ToString();
            }
            else
            {
                lblNota.Text = "Nota no cargada";
            }

        }
    }
}
