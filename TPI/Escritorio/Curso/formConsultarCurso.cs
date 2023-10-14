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
    public partial class formConsultarCurso : Form
    {
        private TPI.Entidades.Especialidad especialidad;
        private TPI.Entidades.Plan plan;
        private TPI.Entidades.Materia materia;
        private TPI.Entidades.Comision comision;
        private TPI.Entidades.Curso curso;
        public formConsultarCurso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void formConsultarCurso_Load(object sender, EventArgs e)
        {
            foreach (TPI.Entidades.Especialidad esp in TPI.Negocio.Especialidad.GetAllEspecialidades())
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }
        }

        private void cbxEspecialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private async void cbxPlanes_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void cbxMaterias_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void cbxComision_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (materia != null && comision != null)
                {
                    curso = TPI.Negocio.Curso.BuscarCursoPorMateriaComision(materia, comision);
                    
                    if (curso == null) { MessageBox.Show("Curso no encontrado"); }
                    else { 
                    formMostrarCurso formMostrarCurso = new formMostrarCurso(curso);
                    formMostrarCurso.Show();
                    }
                    
                }
                else { MessageBox.Show("Error en datos del formulario"); }
            }
            catch
            {
                MessageBox.Show("Error al buscar o mostrar el curso");
            }
        }

        private void cbxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPlanes.Items.Clear();
            cbxMaterias.Items.Clear();
            cbxComision.Items.Clear();
            if (cbxEspecialidades.SelectedItem != null)
            {
                var desc_especialidad = cbxEspecialidades.SelectedItem.ToString();
                if (desc_especialidad != null)
                {
                    especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(desc_especialidad);

                    if (especialidad != null)
                    {
                        
                        foreach (TPI.Entidades.Plan pl in TPI.Negocio.Plan.GetPlanesPorEspecialidad(especialidad))
                        {
                            cbxPlanes.Items.Add(pl.Anio);
                        }
                        
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
            cbxMaterias.Items.Clear();
            foreach (TPI.Entidades.Materia mat in TPI.Negocio.Materia.GetMateriasPorPlan(plan))
            {
                cbxMaterias.Items.Add(mat.Descripcion);
            }
            cbxMaterias.Enabled = true;
            if (cbxPlanes.SelectedItem != null)
            {
                var anio = Convert.ToInt32((cbxPlanes.SelectedItem.ToString()));
                if (especialidad != null)
                {
                    plan = await TPI.Negocio.Plan.GetPlanPorEspecialidadAnio(especialidad, anio);
                }
            }
        }

        private void cbxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
                var desc_materia = cbxMaterias.SelectedItem.ToString();
                if (desc_materia != null)
                {
                    materia = TPI.Negocio.Materia.GetMateriaPorDescripcionYPlan(desc_materia, plan);
                }
            

        }

        private void cbxComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                var nro_com = Convert.ToInt32(cbxComision.SelectedItem.ToString());
                if (especialidad != null)
                {
                    comision = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nro_com, especialidad);
                }
            

        }
    }
}
