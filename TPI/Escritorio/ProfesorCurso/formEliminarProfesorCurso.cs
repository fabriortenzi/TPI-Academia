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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf == DialogResult.Yes)
            {
                int id_materia = int.Parse(txtIdMateria.Text);
            int legajo = int.Parse(txtLegajo.Text);
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
