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
        public formAgregarProfesorCurso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TPI.Entidades.ProfesorCurso profesor_curso = new TPI.Entidades.ProfesorCurso();
            profesor_curso.idMateria = int.Parse(txtIdMateria.Text);
            profesor_curso.Legajo = int.Parse(txtIdMateria.Text);
            profesor_curso.Anio = int.Parse(txtAnio.Text);
            profesor_curso.Cargo = (string)txtCargo.Text;
            TPI.Negocio.ProfesorCurso.Agregar(profesor_curso);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
