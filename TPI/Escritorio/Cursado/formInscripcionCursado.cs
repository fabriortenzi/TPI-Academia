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
    public partial class formInscripcionCursado : Form
    {
        private TPI.Entidades.Usuario Usuario;        

        private TPI.Entidades.Comision Comision;

        private TPI.Entidades.Materia Materia;

        private TPI.Entidades.Curso Curso;

        private List<TPI.Entidades.Curso> CursosMateria;

        public formInscripcionCursado(TPI.Entidades.Usuario usuario)
        {
            Usuario = usuario;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void formInscripcionCursado_Load(object sender, EventArgs e)
        {
            
            CursosMateria = TPI.Negocio.Curso.BuscarCursosPorPlanCicloLectivo(Usuario.Plan, DateTime.Now.Year);


            foreach (TPI.Entidades.Curso curso in CursosMateria)
            {
                cbxCursosMateria.Items.Add(curso.Materia.Descripcion);
            }
        }

        private void cbxCursosMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxComisiones.SelectedIndex = -1;
            cbxComisiones.Items.Clear();
            cbxComisiones.Enabled = true;

            var materiaSeleccionada = cbxCursosMateria.SelectedItem.ToString();
            Materia = TPI.Negocio.Materia.GetMateriaPorDesc(materiaSeleccionada);
            CursosMateria = CursosMateria.Where(x => x.Materia.Id == Materia.Id).ToList();
            
            foreach (var cur in CursosMateria)
            {
                cbxComisiones.Items.Add(cur.Comision.NroComision);
            }
        }

        private void cbxComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nro_com = Convert.ToInt32(cbxComisiones.SelectedItem.ToString());
            Comision = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nro_com, Usuario.Plan.Especialidad);

            if (Materia != null && Comision!=null) {
                Curso = TPI.Negocio.Curso.BuscarCursoPorMateriaComision(Materia, Comision);
              }

            string horario = $"{Curso.Dia} de {Curso.HoraInicio} a {Curso.HoraFin}";
            lblHorarioCurso.Text = horario;
            lblHorarioCurso.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                TPI.Entidades.Cursado cursado = TPI.Negocio.Cursado.Crear(Usuario, Curso, DateTime.Now);
                TPI.Negocio.Cursado.Agregar(cursado);
                MessageBox.Show("Inscripcion relizada con Exito!");
                Dispose();
            }
            catch
            {
                MessageBox.Show("Error al agregar cursado");
            }
        }
    }
}
