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
        public formConsultarProfesorCurso()
        {
            InitializeComponent();
            cargar_cbx();
        }

        private void cargar_cbx()
        {
            List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllProfesores();
            List<TPI.Entidades.Materia> materias = TPI.Negocio.Materia.GetAll();

            foreach (TPI.Entidades.Usuario usu in usuarios) { cbxLegajo.Items.Add(usu.Legajo); }
            foreach (TPI.Entidades.Materia mat in materias) { cbxMateria.Items.Add(mat.Descripcion); }


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string desc_materia = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);
            int legajo = int.Parse(this.cbxLegajo.GetItemText(this.cbxLegajo.SelectedItem));
            TPI.Entidades.Materia materia = TPI.Negocio.Materia.GetMateriaPorDesc(desc_materia);

            int anio = int.Parse(txtAnio.Text);

            TPI.Entidades.ProfesorCurso profesorCurso = TPI.Negocio.ProfesorCurso.GetProfesorCurso(legajo, anio, materia.Id);

            formMostrarProfesorCurso frmMostrarProfesorCurso = new formMostrarProfesorCurso(profesorCurso);
            frmMostrarProfesorCurso.Show();

        }
    }
}
