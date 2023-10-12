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
    public partial class formConsultarCursado : Form
    {
        private TPI.Entidades.Usuario Usuario;
        private TPI.Entidades.Curso Curso;
        private TPI.Entidades.Cursado Cursado;
        public formConsultarCursado()
        {
            InitializeComponent();
        }

        private void formConsultarCursado_Load(object sender, EventArgs e)
        {
            foreach (TPI.Entidades.Usuario us in TPI.Negocio.Usuario.GetAllAlumnos())
            {
                cbxUsuario.Items.Add(us.Persona.Nombre + " " + us.Persona.Apellido);
            }
        }

        private void cbxUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxCurso_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Usuario!= null && Curso!= null) { 
                Cursado = TPI.Negocio.Cursado.BuscarCursoPorUsuarioCurso(Usuario, Curso);
                    if (Cursado != null)
                    {
                        FormMostrarCursado formMostrarCursado = new FormMostrarCursado(Cursado);
                        formMostrarCursado.Show();
                    }
                    else { MessageBox.Show("Cursado Inexistenete"); }
                }
                else { MessageBox.Show("Falta usuario o curso"); }
            }
            catch
            {
                MessageBox.Show("Error al consultar cursado");
            }
        }

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom_ape = cbxUsuario.SelectedItem.ToString();
            Usuario = TPI.Negocio.Usuario.GetUsuarioPorNomyApe(nom_ape);
            if (Usuario != null) { 
            if (txtCiclo.Text != null || txtCiclo.Text != "")
            {
                int ciclo = int.Parse(txtCiclo.Text);
                foreach (TPI.Entidades.Cursado cur in TPI.Negocio.Cursado.BuscarCursadosPorUsuarioAño(Usuario, ciclo))
                {
                    cbxCurso.Items.Add(cur.Curso.Id);
                }

            }
            }
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCurso.SelectedItem != null) { 
            int idCurso = int.Parse(cbxCurso.SelectedItem.ToString());
            Curso = TPI.Negocio.Curso.GetOne(idCurso);
            }
        }
    }
}
