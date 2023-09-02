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
        public formEliminarProfesorCurso()
        {
            InitializeComponent();
            cargar_cbx();
        }

        private void cargar_cbx()
        {
            List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllProfesores();
            List<TPI.Entidades.Materia> materias = TPI.Negocio.Materia.GetAll();

            foreach (TPI.Entidades.Usuario usu in usuarios) { cbxLegajo.Items.Add(usu.Legajo); }
            foreach (TPI.Entidades.Materia mat in materias) { cbxMateria.Items.Add(mat.descMateria); }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf == DialogResult.Yes)
            {

                string desc_materia = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);
                int legajo = int.Parse(this.cbxLegajo.GetItemText(this.cbxLegajo.SelectedItem));
                TPI.Entidades.Materia materia = TPI.Negocio.Materia.GetMateriaPorDesc(desc_materia);

                int id_materia = materia.idMateria;
            
            int anio = int.Parse(txtAnio.Text);
            TPI.Entidades.ProfesorCurso profesor_curso = TPI.Negocio.ProfesorCurso.GetProfesorCurso(legajo, anio, id_materia);
            TPI.Negocio.ProfesorCurso.Eliminar(profesor_curso);
            }
            else { this.Close(); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
