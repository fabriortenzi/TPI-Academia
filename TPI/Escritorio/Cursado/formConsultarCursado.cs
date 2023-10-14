using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Inscripcion
{
    public partial class formConsultarCursado : Form
    {
        private TPI.Entidades.Usuario Usuario;

        private TPI.Entidades.Cursado Cursado;
        private TPI.Entidades.Especialidad especialidad;
        private TPI.Entidades.Plan plan;
        private TPI.Entidades.Materia materia;
        private TPI.Entidades.Comision comision;
        private TPI.Entidades.Curso curso;
        public formConsultarCursado()
        {
            InitializeComponent();
        }

        private void formConsultarCursado_Load(object sender, EventArgs e)
        {
            foreach (TPI.Entidades.Especialidad esp in TPI.Negocio.Especialidad.GetAllEspecialidades())
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }
            foreach (TPI.Entidades.Usuario us in TPI.Negocio.Usuario.GetAllAlumnos())
            {
                cbxUsuario.Items.Add(us.Persona.Nombre + " " + us.Persona.Apellido);
            }

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (materia != null && comision != null)
                {

                    var cur = TPI.Negocio.Curso.BuscarCursoPorMateriaComision(materia, comision);
                    if (cur != null) { curso = cur; } else { MessageBox.Show("Error en el curso"); }
                }
                else { MessageBox.Show("Debe selecionar una materia una comision"); }

                if (Usuario != null && curso != null)
                {
                    Cursado = TPI.Negocio.Cursado.BuscarCursoPorUsuarioCurso(Usuario, curso);
                    if (Cursado != null)
                    {
                        FormMostrarCursado formMostrarCursado = new FormMostrarCursado(Cursado);
                        formMostrarCursado.Show();
                    }
                    else { MessageBox.Show("Cursado Inexistenete"); }
                }
                else { MessageBox.Show("Falta usuario o curso"); }
            }
            catch
            {
                MessageBox.Show("Error al consultar cursado");
            }
        }

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom_ape = cbxUsuario.SelectedItem.ToString();
            Usuario = TPI.Negocio.Usuario.GetUsuarioPorNomyApe(nom_ape);

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
