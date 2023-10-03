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
    public partial class formInscripcionPlan : Form
    {
        private TPI.Entidades.Usuario Usuario;

        private TPI.Entidades.Especialidad Especialidad;

        private TPI.Entidades.Plan Plan;

        public formInscripcionPlan(TPI.Entidades.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        private void formInscripcionCursado_Load(object sender, EventArgs e)
        {
            foreach (var especialidad in TPI.Datos.Especialidades.GetEspecialidades())
            {
                comboBoxEspecialidades.Items.Add(especialidad.Descripcion);
            }
        }

        private void comboBoxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPlanes.SelectedIndex = -1;
            cbxPlanes.Items.Clear();

            var especialidadSeleccionada = comboBoxEspecialidades.SelectedItem.ToString();
            Especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(especialidadSeleccionada);

            foreach (var plan in TPI.Negocio.Plan.GetPlanesPorEspecialidad(Especialidad))
            {
                cbxPlanes.Items.Add(plan.Anio);
            }

            cbxPlanes.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TPI.Negocio.Usuario.AsignarPlanAUsuario(Plan, Usuario);
            MessageBox.Show($"Alumno legajo numero {Usuario.Legajo} creado con exito!");
            Dispose();
        }

        private void txtAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAlumno_Click(object sender, EventArgs e)
        {

        }

        private async void cbxPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var añoPlan = Convert.ToInt32(cbxPlanes.SelectedItem.ToString());
            Plan = await TPI.Negocio.Plan.GetPlanPorEspecialidadAnio(Especialidad, añoPlan);

            btnAceptar.Enabled = true;
        }

        private void formInscripcionPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("El Alumno debe tener un plan registrado", "Asignar Plan", MessageBoxButtons.OK);
            e.Cancel = true;
            return;
        }
    }
}
