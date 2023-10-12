using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Escritorio.Curso
{
    public partial class formEliminarCurso : Form
    {
        private TPI.Entidades.Especialidad especialidad;
        private TPI.Entidades.Plan plan;
        private TPI.Entidades.Materia materia;
        private TPI.Entidades.Comision comision;
        private TPI.Entidades.Curso curso;
        public formEliminarCurso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void formEliminarCurso_Load(object sender, EventArgs e)
        {
            foreach (TPI.Entidades.Especialidad esp in TPI.Negocio.Especialidad.GetAllEspecialidades())
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }
        }

        private async void cbxPlanes_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxEspecialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxComision_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }

        private void cbxMaterias_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el curso?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                if(materia !=null && comision != null) { 
                curso = TPI.Negocio.Curso.BuscarCursoPorMateriaComision(materia, comision);
                if(curso != null) { 
                TPI.Negocio.Curso.Eliminar(curso);
                MessageBox.Show("Curso eliminado");
                }
                else { MessageBox.Show("Curso no encontrado"); }
                }
                else { MessageBox.Show("Error en datos del formulario"); }
            }
            else
            {
            }

        }

        private void cbxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (cbxEspecialidades.SelectedItem != null) { 
            var desc_especialidad = cbxEspecialidades.SelectedItem.ToString();
            if (desc_especialidad != null) { 
            especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(desc_especialidad);
                    
                    if (especialidad != null) {
                        cbxPlanes.Items.Clear();
                    foreach (TPI.Entidades.Plan pl in TPI.Negocio.Plan.GetPlanesPorEspecialidad(especialidad))
                    {
                        cbxPlanes.Items.Add(pl.Anio);
                    }
                        cbxComision.Items.Clear();
                        foreach (TPI.Entidades.Comision com in TPI.Negocio.Comision.BuscarComisionesPorEspecialidad(especialidad))
                    {
                        cbxComision.Items.Add(com.NroComision);
                    }
                    cbxPlanes.Enabled = true;
                    cbxComision.Enabled = true;
                    }
                }
            }
        }

        private async void cbxPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TPI.Entidades.Materia mat in TPI.Negocio.Materia.GetMateriasPorPlan(plan))
            {
                cbxMaterias.Items.Add(mat.Descripcion);
            }
            cbxMaterias.Enabled = true;
            if (cbxPlanes.SelectedItem != null) { 
            var anio = Convert.ToInt32((cbxPlanes.SelectedItem.ToString()));
                if (especialidad != null) { 
            plan = await TPI.Negocio.Plan.GetPlanPorEspecialidadAnio(especialidad, anio);
            }
            }
        }

        private void cbxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxMaterias.SelectedItem != null) { 
            var desc_materia = cbxMaterias.SelectedItem.ToString();
            if (desc_materia!=null){ 
            materia = TPI.Negocio.Materia.GetMateriaPorDescripcionYPlan(desc_materia, plan);
            }
            }
        }

        private void cbxComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxComision.SelectedItem != null){ 
            var nro_com = Convert.ToInt32(cbxComision.SelectedItem.ToString());
                if (especialidad != null) { 
            comision = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nro_com, especialidad);
                }
            }
        }




    }
    }

