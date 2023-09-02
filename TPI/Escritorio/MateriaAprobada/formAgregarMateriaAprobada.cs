using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Escritorio.MateriaAprobada
{
    public partial class formAgregarMateriaAprobada : Form
    {
        public formAgregarMateriaAprobada(TPI.Entidades.Usuario profesor)
        {
            InitializeComponent();
            cargar_cbxMateria(profesor);
        }

       
        private void cargar_cbxMateria(TPI.Entidades.Usuario profesor)
        {
            
            List<TPI.Entidades.Materia> materias_profesor = TPI.Negocio.ProfesorCurso.GetMaterias_Cursos(profesor);
            foreach (TPI.Entidades.Materia materia in materias_profesor)
            {
                cbxMateria.Items.Add(materia.descMateria);
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            TPI.Entidades.MateriaAprobada materia_aprobada = new TPI.Entidades.MateriaAprobada();

            string desc_materia = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);

            string nom_ape_alumno = this.cbxAlumno.GetItemText(this.cbxAlumno.SelectedItem);

            TPI.Entidades.Materia materia = TPI.Negocio.Materia.GetMateriaPorDesc(desc_materia);

            TPI.Entidades.Usuario alumno = TPI.Negocio.Usuario.GetUsuarioPorNomyApe(nom_ape_alumno);

            materia_aprobada.idMateria = materia.idMateria;
            materia_aprobada.Legajo = alumno.Legajo;
            materia_aprobada.Nota = (int)nudNota.Value;
            TPI.Negocio.MateriaAprobada.Agregar(materia_aprobada);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string desc_materia = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);
            TPI.Entidades.Materia materia = TPI.Negocio.Materia.GetMateriaPorDesc(desc_materia);
            cargar_cbxAlumno(materia);
            cbxAlumno.Enabled = true;
        }

        private void cargar_cbxAlumno(TPI.Entidades.Materia materia)
        {
            List<TPI.Entidades.Usuario> alumnos = TPI.Negocio.InscripcionCursado.GetAllAlumnosPorMateria(materia);
            foreach (TPI.Entidades.Usuario alu in alumnos)
            {
                cbxMateria.Items.Add(alu.Persona.Nombre +" "+ alu.Persona.Apellido);
            }            
        }

        private void cbxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudNota.Enabled = true;
        }
    }
}
