using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Cursado
{
    public partial class formModificarCursado : Form
    {
        private TPI.Entidades.Usuario Usuario;
        private TPI.Entidades.Curso Curso;
        private TPI.Entidades.Cursado Cursado;
        public formModificarCursado(TPI.Entidades.Cursado cursado)
        {
            Cursado = cursado;
            Curso = TPI.Negocio.Curso.GetOne(cursado.Curso.Id);
            Usuario = TPI.Negocio.Usuario.GetOne(cursado.Usuario.Legajo);
            InitializeComponent();
        }

        private void formModificarCursado_Load(object sender, EventArgs e)
        {
            cbxUsuario.SelectedItem = Cursado.Usuario.NombreCompleto;
            
            cbxCurso.SelectedItem = Curso.Id.ToString();
            lblMateria.Text = Curso.Materia.Descripcion;


            foreach (TPI.Entidades.Usuario us in TPI.Negocio.Usuario.GetAllAlumnos())
            {
                cbxUsuario.Items.Add(us.Persona.Nombre + " " + us.Persona.Apellido);
            }
            foreach (TPI.Entidades.Curso cur in TPI.Negocio.Curso.GetAll())
            {
                cbxCurso.Items.Add(cur.Id);
            }
        }

        private void cbxUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCurso.SelectedItem != null)
            {
                var idCurso = Convert.ToInt32(cbxCurso.SelectedItem.ToString());
                Curso = TPI.Negocio.Curso.GetOne(idCurso);
                lblMateria.Text = Curso.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var nota = Convert.ToInt32(nupNota.Value);
            try
            {


                bool validar_curso = TPI.Negocio.Cursado.ValidarCurso(Usuario, Curso);
                bool validar_nota = TPI.Negocio.Cursado.ValidarNota(nota);

                if (validar_curso && validar_nota)
                {
                    if (Cursado != null && Usuario != null && Curso != null)
                    {

                        TPI.Negocio.Cursado.Cambiar(Cursado);
                    }
                }
                if (validar_curso == false)
                {
                    MessageBox.Show("Error en el curso se superpone con otro curso, elimine primero el curso superpuesto");
                }
                if (validar_nota == false)
                {
                    MessageBox.Show("Error en la nota. Recuerde que la misma debe ser un entero de 0 a 10");
                }
            }
            catch
            {
                MessageBox.Show("Error al modificar cursado");
            }


        }

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usu = TPI.Negocio.Usuario.GetUsuarioPorNomyApe(cbxUsuario.SelectedItem.ToString());
            Usuario = TPI.Negocio.Usuario.GetOne(usu.Legajo);

        }
    }
}
