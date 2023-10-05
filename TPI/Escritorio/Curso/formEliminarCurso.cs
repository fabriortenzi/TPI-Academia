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
            foreach(TPI.Entidades.Especialidad esp in TPI.Negocio.Especialidad.GetAllEspecialidades()) 
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }
        }

        private void cbxPlanes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (TPI.Entidades.Materia mat in TPI.Negocio.Materia.GetMateriasPorPlan(plan))
            {
                cbxMaterias.Items.Add(mat.Descripcion);
            }
            cbxMaterias.Enabled = true;
            int anio = int.Parse(cbxPlanes.SelectedItem.ToString());
            plan = TPI.Negocio.Plan.GetPlanPorEspecialidadAnio(especialidad, anio);
        }

        private void cbxEspecialidades_SelectionChangeCommitted(object sender, EventArgs e)
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
            string desc_especialidad = cbxEspecialidades.SelectedItem.ToString();
            especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(desc_especialidad);
        }

        private void cbxComision_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int nro_com = int.Parse(cbxComision.SelectedItem.ToString());
            comision = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nro_com, especialidad);
            
            
        }

        private void cbxMaterias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string desc_materia = cbxMaterias.SelectedItem.ToString();
            materia = TPI.Negocio.Materia.GetMateriaPorDescripcionYPlan(desc_materia, plan);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el curso?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (resultado == DialogResult.Yes)
            {
                curso = TPI.Negocio.Curso.BuscarCursoPorMateriaComision(materia, comision);
                TPI.Negocio.Curso.Eliminar(curso);
                MessageBox.Show("Curso eliminado");
            }
            else
            {
            }

        }
    }
}
