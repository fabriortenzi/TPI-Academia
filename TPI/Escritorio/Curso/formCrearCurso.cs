using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class formCrearCurso : Form
    {
        private TPI.Entidades.Especialidad Especialidad;
        private int Año;
        private TPI.Entidades.Materia Materia;
        private TPI.Entidades.Plan Plan;

        public formCrearCurso()
        {
            InitializeComponent();
        }

        private void formCrearCurso_Load(object sender, EventArgs e)
        {
            var especialidades = TPI.Negocio.Especialidad.GetAllEspecialidades();

            foreach (var esp in especialidades)
            {
                cbxEspecialidades.Items.Add(esp.descEspec);
            }
        }

        private void cbxEspecialidades_TextUpdate(object sender, EventArgs e)
        {
        }

        private void cbxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPlanes.SelectedIndex = -1;
            cbxPlanes.Items.Clear();
            cbxPlanes.Enabled = true;

            cbxMaterias.SelectedIndex = -1;
            cbxMaterias.Items.Clear();

            var especialidadSeleccionada = cbxEspecialidades.SelectedItem.ToString();
            var especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(especialidadSeleccionada);
            Especialidad = especialidad;
            var planesPorEspecialidad = TPI.Negocio.Plan.GetPlanesPorEspecialidad(especialidad);

            foreach (var plan in planesPorEspecialidad)
            {
                cbxPlanes.Items.Add(plan.anio);
            }
        }

        private void cbxPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMaterias.SelectedIndex = -1;
            cbxMaterias.Items.Clear();
            cbxMaterias.Enabled = true;

            if (cbxPlanes.SelectedItem != null)
            {
                var añoPlanSeleccionado = Convert.ToInt32(cbxPlanes.SelectedItem.ToString());
                Año = añoPlanSeleccionado;
                var planSeleccionado = TPI.Negocio.Plan.GetPlanPorEspecialidadAnio(Especialidad, Año);
                Plan = planSeleccionado;
                var materiasPlan = TPI.Negocio.Materia.GetMateriasPorPlan(planSeleccionado);

                foreach (var materia in materiasPlan)
                {
                    cbxMaterias.Items.Add(materia.descMateria);
                }
            }
        }

        private void cbxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            var descripcionMateriaSelecc = cbxMaterias.SelectedItem.ToString();
            var materiaSeleccionada = TPI.Negocio.Materia.GetMateriaPorDescripcionYPlan(descripcionMateriaSelecc, Plan);
            Materia = materiaSeleccionada;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int año = 0, cupo = 0;

            try
            {
                año = Convert.ToInt32(txtAño.Text);
                cupo = Convert.ToInt32(txtCupo.Text);
            }
            catch
            {
                MessageBox.Show("Año y cupo no pueden contener letras ni estar vacios");
                return;
            }

            if (año != 0 && cupo != 0)
            {
                var curso = TPI.Negocio.Curso.CrearCurso(año, cupo, Materia);
                TPI.Negocio.Curso.AgregarCurso(curso);
                MessageBox.Show("Curso creado exitosamente!");
                Dispose();
            }
        }
    }
}
