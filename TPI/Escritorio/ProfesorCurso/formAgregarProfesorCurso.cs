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
    public partial class formAgregarProfesorCurso : Form
    {
        private TPI.Entidades.Usuario Usuario;
        private TPI.Entidades.Especialidad especialidad;
        private TPI.Entidades.Plan plan;
        private TPI.Entidades.Materia materia;
        private TPI.Entidades.Comision comision;
        private TPI.Entidades.Curso curso;
        public formAgregarProfesorCurso()
        {
            InitializeComponent();


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


        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void cbxLegajo_SelectedIndexChanged(object sender, EventArgs e)
        {


            int leg = Convert.ToInt32(cbxLegajo.SelectedValue);
            Usuario = TPI.Negocio.Usuario.GetOne(leg);

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (materia != null && comision != null)
            {
                curso = TPI.Negocio.Curso.BuscarCursoPorMateriaComision(materia, comision);
                if (curso != null && Usuario != null)
                {
                    TPI.Entidades.ProfesorCurso profesor_curso = new TPI.Entidades.ProfesorCurso();

                    profesor_curso.Curso = curso;
                    profesor_curso.Usuario = Usuario;
                    profesor_curso.Cargo = txtCargo.Text;
                    if (profesor_curso != null)
                    {
                        TPI.Negocio.ProfesorCurso.Agregar(profesor_curso);
                        MessageBox.Show("Cargo asignado con exito!");
                        this.Close();
                    }
                    else { MessageBox.Show("Un profesor curso debe tener un usuario y un curso"); }
                }
            }
            else { MessageBox.Show("Seleccione una materia y una comision"); }
            
        }

        private void formAgregarProfesorCurso_Load(object sender, EventArgs e)
        {

            cargar_cbx();
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
