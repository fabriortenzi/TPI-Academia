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
    public partial class formConsultarProfesorCurso : Form
    {
        private TPI.Entidades.Usuario? Usuario;
        private TPI.Entidades.Curso Curso;
        public formConsultarProfesorCurso()
        {
            InitializeComponent();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            TPI.Entidades.ProfesorCurso profesorCurso = TPI.Negocio.ProfesorCurso.BuscarPorUsuarioCurso(Usuario, Curso);

            if (profesorCurso != null)
            {
                formMostrarProfesorCurso frmMostrarProfesorCurso = new formMostrarProfesorCurso(profesorCurso);
                frmMostrarProfesorCurso.Show();
            }
            else { MessageBox.Show("Error"); }

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

        private void formConsultarProfesorCurso_Load(object sender, EventArgs e)
        {
            List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllProfesores();


            foreach (TPI.Entidades.Usuario usu in usuarios) { cbxLegajo.Items.Add(usu.Legajo); }



        }
    }
}
