using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.ProfesorCurso
{
    public partial class formEliminarProfesorCurso : Form
    {
        private TPI.Entidades.Usuario? Usuario;
        private TPI.Entidades.Especialidad especialidad;
        private TPI.Entidades.Plan plan;
        private TPI.Entidades.Materia materia;
        private TPI.Entidades.Comision comision;
        private TPI.Entidades.Curso curso;
        public formEliminarProfesorCurso()
        {
            InitializeComponent();

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formEliminarProfesorCurso_Load(object sender, EventArgs e)
        {
            cargar_cbx();

        }

        private void cargar_cbx()
        {


            cbxLegajo.DisplayMember = "NombreCompleto";
            cbxLegajo.ValueMember = "Legajo";

            List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllProfesores();


            foreach (TPI.Entidades.Especialidad esp in TPI.Negocio.Especialidad.GetAllEspecialidades())
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }

            cbxLegajo.DataSource = usuarios;


            cbxEspecialidades.SelectedIndex = -1;
            cbxLegajo.SelectedIndex = -1;



        }



        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf == DialogResult.Yes)
            {
                if (materia != null && comision != null)
                {
                    curso = TPI.Negocio.Curso.BuscarCursoPorMateriaComision(materia, comision);
                    if (curso != null && Usuario != null)
                    {
                        var profesor_curso = TPI.Negocio.ProfesorCurso.BuscarPorUsuarioCurso(Usuario, curso);
                        if (profesor_curso != null)
                        {
                            TPI.Negocio.ProfesorCurso.Eliminar(profesor_curso);
                            MessageBox.Show("Cargo eliminado con exito");
                            Dispose();
                        }
                        else { MessageBox.Show("Erro al ingresar datos por favor intenete nuevamente"); }
                    }
                    else { MessageBox.Show("Un profesor curso debe tener un usuario y un curso"); }
                }
                else { MessageBox.Show("Seleccione una materia y una comision"); }

            }


            else { this.Close(); }
        }

        private void cbxLegajo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int leg = Convert.ToInt32(cbxLegajo.SelectedValue);
            Usuario = TPI.Negocio.Usuario.GetOne(leg);
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
            if (cbxEspecialidades.SelectedIndex != -1)
            {
                if (cbxPlanes.SelectedItem != null)
                {
                    var anio = Convert.ToInt32((cbxPlanes.SelectedItem.ToString()));
                    if (especialidad != null)
                    {
                        plan = await TPI.Negocio.Plan.GetPlanPorEspecialidadAnio(especialidad, anio);
                    }
                }
                cbxMaterias.Items.Clear();
                foreach (TPI.Entidades.Materia mat in TPI.Negocio.Materia.GetMateriasPorPlan(plan))
                {
                    cbxMaterias.Items.Add(mat.Descripcion);
                }
                cbxMaterias.Enabled = true;
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
