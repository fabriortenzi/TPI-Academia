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
        private TPI.Entidades.Comision comision;
        private string DiaSemana;

        public formCrearCurso()
        {
            InitializeComponent();
        }

        private void formCrearCurso_Load(object sender, EventArgs e)
        {
            var especialidades = TPI.Negocio.Especialidad.GetAllEspecialidades();

            foreach (var esp in especialidades)
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }
        }

        private void cbxEspecialidades_TextUpdate(object sender, EventArgs e)
        {
        }

        private void cbxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPlanes.SelectedIndex = -1;
            cbxPlanes.Items.Clear();

            var especialidadSeleccionada = cbxEspecialidades.SelectedItem.ToString();
            var especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(especialidadSeleccionada);
            Especialidad = especialidad;
            var planesPorEspecialidad = TPI.Negocio.Plan.GetPlanesPorEspecialidad(especialidad);

            cbxComision.SelectedIndex = -1;
            cbxComision.Items.Clear();
            foreach (var com in TPI.Negocio.Comision.BuscarComisionesPorEspecialidad(especialidad))
            {
                cbxComision.Items.Add(com.NroComision);
            }
            cbxComision.Enabled = true;


            foreach (var plan in planesPorEspecialidad)
            {
                cbxPlanes.Items.Add(plan.Anio);
            }
            cbxPlanes.Enabled = true;
        }

        private async void cbxPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMaterias.SelectedIndex = -1;
            cbxMaterias.Items.Clear();


            if (cbxPlanes.SelectedItem != null)
            {
                var añoPlanSeleccionado = Convert.ToInt32(cbxPlanes.SelectedItem.ToString());
                Año = añoPlanSeleccionado;
                var planSeleccionado = await TPI.Negocio.Plan.GetPlanPorEspecialidadAnio(Especialidad, Año);
                Plan = planSeleccionado;
                var materiasPlan = TPI.Negocio.Materia.GetMateriasPorPlan(planSeleccionado);



                foreach (var materia in materiasPlan)
                {
                    cbxMaterias.Items.Add(materia.Descripcion);
                }
                cbxMaterias.Enabled = true;
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
            string dia;
            TimeSpan hora_ini, hora_fin;
            try
            {
                año = Convert.ToInt32(txtAño.Text);
                cupo = Convert.ToInt32(txtCupo.Text);
                dia = txtDia.Text;
                hora_ini = dtpHoraIni.Value.TimeOfDay;
                hora_fin = dtpHoraFin.Value.TimeOfDay;
            }
            catch
            {
                MessageBox.Show("Error en los datos del formulario de curso");
                return;
            }

            if (año != 0 && cupo != 0)
            {
                var curso = TPI.Negocio.Curso.Crear(Materia, año, comision, cupo, dia, hora_ini, hora_fin);
                TPI.Negocio.Curso.Agregar(curso);
                MessageBox.Show("Curso creado exitosamente!");
                Dispose();
            }
        }

        private void cbxComision_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cbxComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nro_com = int.Parse(cbxComision.SelectedItem.ToString());
            comision = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nro_com, Especialidad);
        }
    }
}
