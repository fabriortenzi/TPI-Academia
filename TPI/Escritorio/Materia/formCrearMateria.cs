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
    public partial class formCrearMateria : Form
    {
        TPI.Entidades.Especialidad Especialidad;
        TPI.Entidades.Plan Plan;
        public formCrearMateria()
        {
            InitializeComponent();
        }

        private void formCrearMateria_Load(object sender, EventArgs e)
        {
            
            TPI.Datos.Materia.inicializarMaterias();

            var especialidades = TPI.Negocio.Especialidad.GetAllEspecialidades();

            foreach(var esp in especialidades)
            {
                cbxEspecialidades.Items.Add(esp.descEspec);
            }
        }

        private void cbxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPlanes.SelectedIndex = -1;
            cbxPlanes.Items.Clear();
            cbxPlanes.Enabled = true;

            var especialidadSeleccionada = cbxEspecialidades.SelectedItem.ToString();
            var especialidad = TPI.Datos.Especialidades.GetEspecialidad(especialidadSeleccionada);

            Especialidad = especialidad; //me llevo la especialidad que eligio
            
            var planes = TPI.Datos.Plan.GetPlanesPorEspecialidad(especialidad);
            
            foreach(var plan in planes)
            {
                cbxPlanes.Items.Add(plan.anio);
            }
        }

        private void cbxPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var añoplanseleccionado = Convert.ToInt32(cbxPlanes.SelectedItem.ToString());
            var plan = TPI.Datos.Plan.GetPlanPorEspecialidadAnio(Especialidad,añoplanseleccionado);
           
            Plan = plan;
        }

        private void txtDescMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorasSem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorasTot_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var descMateria = txtDescMateria.Text;

                var horas_sem = Convert.ToInt32(txtHorasSem.Text);

                var horas_tot = Convert.ToInt32(txtHorasTot.Text);

                var nuevamateria = TPI.Negocio.Materia.CrearMateria(descMateria, horas_sem, horas_tot, Plan);

                TPI.Negocio.Materia.AgregaMateria(nuevamateria);

                MessageBox.Show("Materia creada con exito!");
                Dispose();
            }

            catch
            {
                MessageBox.Show("Asegurese de no haber ingresado letras a la hora de cargar las horas y" +
                    " de no haber dejado un campo en blanco");
            }
        }
    }
}
