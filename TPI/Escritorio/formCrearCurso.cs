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
        TPI.Entidades.Especialidad Especialidad;
        
        public formCrearCurso()
        {
            InitializeComponent();
        }

        private void formCrearCurso_Load(object sender, EventArgs e)
        {
            

            TPI.Datos.Materia.inicializarMaterias();

            var especialidades = TPI.Negocio.Especialidad.GetAllEspecialidades();

            var planes = TPI.Negocio.Plan.GetAllPlanes();

            var materias = TPI.Negocio.Materia.Getallmaterias();


            foreach (var esp in especialidades)
            {
                cbxEspecialidades.Items.Add(esp.descEspec);
            }

            foreach (var plan in planes)
            {
                cbxPlanes.Items.Add(plan.descPlan);
            }

            foreach (var materia in materias)
            {
                cbxMaterias.Items.Add(materia.descMateria);
            }
        }

        private void cbxEspecialidades_TextUpdate(object sender, EventArgs e)
        {
            cbxPlanes.Items.Clear(); // Limpiar los items existentes en cbxPlanes

            var especialidadSeleccionada = cbxEspecialidades.SelectedItem.ToString();
            
            if (especialidadSeleccionada != null)
            {

                var especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(especialidadSeleccionada);

                var planesPorEspecialidad = TPI.Negocio.Plan.GetPlanesPorEspecialidad(especialidad);
                foreach (var plan in planesPorEspecialidad)
                {
                    cbxPlanes.Items.Add(plan.descPlan);
                }
            }
        }
    }
}
