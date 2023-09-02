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
            cargar_cbx();

        }
        private void cargar_cbx() 
        {
            List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllProfesores();
            List<TPI.Entidades.Materia> materias = TPI.Negocio.Materia.GetAll();

            foreach (TPI.Entidades.Usuario usu in usuarios) { cbxLegajo.Items.Add(usu.Legajo); }
            foreach (TPI.Entidades.Materia mat in materias) { cbxMateria.Items.Add(mat.descMateria); }


        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TPI.Entidades.ProfesorCurso profesor_curso = new TPI.Entidades.ProfesorCurso();

            string desc_materia = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);
            int legajo = int.Parse(this.cbxLegajo.GetItemText(this.cbxLegajo.SelectedItem));
            TPI.Entidades.Materia materia = TPI.Negocio.Materia.GetMateriaPorDesc(desc_materia);

            profesor_curso.idMateria = materia.idMateria;
            profesor_curso.Legajo = legajo;
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
