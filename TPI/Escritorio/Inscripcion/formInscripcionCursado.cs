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

        private List<TPI.Entidades.Comision> Comisiones;

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
            var cursosMateria = TPI.Negocio.Curso.GetCursosPorPlanYAñoActual(Usuario.Plan);
            CursosMateria = cursosMateria;

            foreach (TPI.Entidades.Curso curso in cursosMateria)
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
            Curso = CursosMateria.FirstOrDefault(cm => cm.Materia.Descripcion == materiaSeleccionada);
            Materia = Curso.Materia;

            //var Comisiones = TPI.Negocio.MateriaComision.GetComisionesPorMateria(Curso.Materia);

            foreach (var com in Comisiones)
            {
                cbxComisiones.Items.Add(com.Id);
            }
        }

        private void cbxComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var comisionSeleccionada = Convert.ToInt32(cbxComisiones.SelectedItem.ToString());
            //Comision = TPI.Negocio.Comision.GetComisionPorId(comisionSeleccionada, Usuario.Plan.IdEspecialidad);

            //MateriaComision = TPI.Negocio.MateriaComision.GetMateriaComision(Materia.idMateria, Comision.IdEspecialidad, Comision.IdCom);

            //string horario = $"{MateriaComision.dia} de {MateriaComision.hora_ini} a {MateriaComision.hora_fin}";
            //lblHorarioCurso.Text = horario;
            //lblHorarioCurso.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //var inscripcion = TPI.Negocio.InscripcionCursado.CrearInscripcion(Curso, Usuario, Comision);
            //TPI.Negocio.InscripcionCursado.AgregarInscripcion(inscripcion);

            MessageBox.Show("Inscripcion relizada con Exito!");
            Dispose();
        }
    }
}
