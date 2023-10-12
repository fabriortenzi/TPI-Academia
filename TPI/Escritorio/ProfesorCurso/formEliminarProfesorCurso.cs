using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.ProfesorCurso
{
    public partial class formEliminarProfesorCurso : Form
    {
        private TPI.Entidades.Usuario? Usuario;
        private TPI.Entidades.Curso Curso;
        public formEliminarProfesorCurso()
        {
            InitializeComponent();

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formEliminarProfesorCurso_Load(object sender, EventArgs e)
        {
            List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllProfesores();


            foreach (TPI.Entidades.Usuario usu in usuarios) { cbxLegajo.Items.Add(usu.Legajo); }

        }

        private void cbxCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxLegajo_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cbxLegajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int legajo = int.Parse(this.cbxLegajo.GetItemText(this.cbxLegajo.SelectedItem));
            Usuario = TPI.Negocio.Usuario.GetAllProfesores().FirstOrDefault(x => x.Legajo == legajo);

            if (Usuario != null)
            {
                List<TPI.Entidades.ProfesorCurso> profesores_cursos = TPI.Negocio.ProfesorCurso.BuscarPorUsuario(Usuario);

                foreach (TPI.Entidades.ProfesorCurso cur in profesores_cursos) { cbxCurso.Items.Add(cur.Curso.Id); }
                cbxCurso.Enabled = true;
            }

        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_curso = Convert.ToInt32(this.cbxCurso.GetItemText(this.cbxCurso.SelectedItem));
            Curso = TPI.Negocio.Curso.GetOne(id_curso);

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf == DialogResult.Yes)
            {

                var profesor_curso = TPI.Negocio.ProfesorCurso.BuscarPorUsuarioCurso(Usuario, Curso);
                if (profesor_curso != null)
                {
                    TPI.Negocio.ProfesorCurso.Eliminar(profesor_curso);
                    MessageBox.Show("Cargo eliminado con exito");
                }
                else { MessageBox.Show("Erro al ingresar datos por favor intenete nuevamente"); }
            }
            else { this.Close(); }
        }
    }
}
