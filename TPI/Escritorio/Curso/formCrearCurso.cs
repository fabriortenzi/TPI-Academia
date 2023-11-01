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
            CargarDiaSemana();
            var especialidades = TPI.Negocio.Especialidad.GetAllEspecialidades()
                .OrderBy(e => e.Descripcion).ToList();

            foreach (var esp in especialidades)
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }
        }

        private void CargarDiaSemana()
        {
            cbxDiaSemana.Items.Clear();
            cbxDiaSemana.Items.Add("Lunes");
            cbxDiaSemana.Items.Add("Martes");
            cbxDiaSemana.Items.Add("Miércoles");
            cbxDiaSemana.Items.Add("Jueves");
            cbxDiaSemana.Items.Add("Viernes");
            cbxDiaSemana.Items.Add("Sábado");
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
            foreach (var com in TPI.Negocio.Comision.BuscarComisionesPorEspecialidad(especialidad).OrderBy(c => c.NroComision).ToList())
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
                var materiasPlan = TPI.Negocio.Materia.GetMateriasPorPlan(planSeleccionado)
                    .OrderBy(m => m.Descripcion).ToList();

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
            if (materiaSeleccionada != null) { Materia = materiaSeleccionada; }
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
                dia = DiaSemana;
                hora_ini = dtpHoraIni.Value.TimeOfDay;
                hora_fin = dtpHoraFin.Value.TimeOfDay;

                if (año <= 0 || cupo <= 0) { MessageBox.Show("Año o cupo invalido", "Crear Curso", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

                if (Materia == null || comision == null) { MessageBox.Show("No puede existir curso sin comision y materia", "Crear Curso", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

                if (año > 0 && cupo > 0 && Materia != null && comision != null)
                {
                    var cur = TPI.Negocio.Curso.BuscarCursoPorMateriaComisionCiclLectivo(Materia, comision, año);
                    if (cur != null) { MessageBox.Show("El curso ya existe", "Crear Curso", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                    else
                    {
                        var curso = TPI.Negocio.Curso.Crear(Materia, año, comision, cupo, dia, hora_ini, hora_fin);
                        TPI.Negocio.Curso.Agregar(curso);
                        MessageBox.Show("Curso creado exitosamente!", "Crear Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en los datos del formulario de curso", "Crear Curso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void cbxComision_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cbxComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxComision.SelectedItem != null)
            {
                var nro_com = Convert.ToInt32(cbxComision.SelectedItem.ToString());
                if (Especialidad != null)
                {
                    comision = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nro_com, Especialidad);
                }
            }
        }

        private void cbxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiaSemana = cbxDiaSemana.SelectedItem.ToString();
        }

        private void lblComision_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void dtpHoraFin_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpHoraIni_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
