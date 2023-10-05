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
    public partial class formAgregarProfesorCurso : Form
    {
        private TPI.Entidades.Usuario Usuario;
        private TPI.Entidades.Curso Curso;
        public formAgregarProfesorCurso()
        {
            InitializeComponent();
            cargar_cbx();

        }
        private void cargar_cbx() 
        {
            List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllProfesores();
            List<TPI.Entidades.Curso> curso = TPI.Negocio.Curso.GetAll();

            foreach (TPI.Entidades.Usuario usu in usuarios) { cbxLegajo.Items.Add(usu.Legajo); }
            foreach (TPI.Entidades.Curso cur in curso) { cbxMateria.Items.Add(cur.Id); }


        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TPI.Entidades.ProfesorCurso profesor_curso = new TPI.Entidades.ProfesorCurso();

            profesor_curso.Curso = Curso;
            profesor_curso.Usuario = Usuario;
            profesor_curso.Cargo = txtCargo.Text;
            TPI.Negocio.ProfesorCurso.Agregar(profesor_curso);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxLegajo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int leg = Convert.ToInt32(cbxLegajo.SelectedItem.ToString());
            Usuario = TPI.Negocio.Usuario.GetAllProfesores().FirstOrDefault(x => x.Legajo == leg);

        }

        private void cbxMateria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idCurso = Convert.ToInt32(cbxMateria.SelectedItem.ToString());
            Curso = TPI.Negocio.Curso.GetOne(idCurso);
        }
    }
}
