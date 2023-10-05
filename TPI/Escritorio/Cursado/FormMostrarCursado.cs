using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Inscripcion
{
    public partial class FormMostrarCursado : Form
    {
        private TPI.Entidades.Cursado Cursado;
        public FormMostrarCursado(TPI.Entidades.Cursado cursado)
        {
            Cursado = cursado;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void FormMostrarCursado_Load(object sender, EventArgs e)
        {
            lblAño.Text = Cursado.Curso.CicloLectivo.ToString();
            lblUsuario.Text = (Cursado.Usuario.Persona.Nombre + " " + Cursado.Usuario.Persona.Apellido);
            lblCurso.Text = Cursado.Curso.Id.ToString();
            lblFecha.Text = Cursado.FechaHoraInscripcion.ToString();
            if (Cursado.NotaFinal>=0 && Cursado.NotaFinal <= 10) { 
            lblNota.Text = Cursado.NotaFinal.ToString();
            }
            else 
            {
                lblNota.Text ="Nota no cargada"
            }

        }
    }
}
