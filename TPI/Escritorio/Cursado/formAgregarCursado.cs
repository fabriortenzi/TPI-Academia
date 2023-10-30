using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Cursado
{
    public partial class formAgregarCursado : Form
    {
        private TPI.Entidades.Usuario Usuario;

        private TPI.Entidades.Plan? Plan;

        private TPI.Entidades.Comision Comision;

        private TPI.Entidades.Materia Materia;

        private TPI.Entidades.Curso Curso;

        private List<TPI.Entidades.Curso> CursosMateria;
        public formAgregarCursado()
        {
            InitializeComponent();
        }

        private void formAgregarCursado_Load(object sender, EventArgs e)
        {

            foreach (var alu in TPI.Negocio.Usuario.GetAllAlumnos())
            {
                cbxAlumno.Items.Add($"{alu.Persona.Nombre} {alu.Persona.Apellido}");
            }
            lblHorarioCurso.Text = "";

        }

        private void cbxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usu = TPI.Negocio.Usuario.GetUsuarioPorNomyApe(cbxAlumno.SelectedItem.ToString());
            Usuario = TPI.Negocio.Usuario.GetOne(usu.Legajo);
            Plan = Usuario.Plan;
            cbxCursosMateria.SelectedIndex = -1;
            cbxCursosMateria.Items.Clear();
            cbxCursosMateria.Enabled = true;

            if (Plan != null)
            {
                CursosMateria = TPI.Negocio.Curso.BuscarCursosPorPlanCicloLectivo(Usuario, DateTime.Now.Year);
            }
            if (Plan == null)
            {
                MessageBox.Show("El usuario no posee un plan");
                this.Close();
            }

            if (CursosMateria.Count == 0)
            {
                MessageBox.Show("Ya te has inscripto a todos los cursos posibles");
                this.Close();
            }

            var materias = new List<string>();
            foreach (var curso in CursosMateria)
            {
                materias.Add(curso.Materia.Descripcion);
            }

            // Como distintos Cursos pueden tener la misma Materia, lo filtro
            materias = materias.Distinct().ToList();

            if (CursosMateria != null)
            {
                foreach (string materia in materias)
                {
                    cbxCursosMateria.Items.Add(materia);
                }
            }
        }

        private void cbxCursosMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHorarioCurso.Text = "";
            cbxComisiones.SelectedIndex = -1;
            cbxComisiones.Items.Clear();
            cbxComisiones.Enabled = true;

            if (cbxCursosMateria.SelectedItem != null)
            {
                var materiaSeleccionada = cbxCursosMateria.SelectedItem.ToString();
                Materia = TPI.Negocio.Materia.GetMateriaPorDesc(materiaSeleccionada);

                if (Materia != null)
                {
                    var Cursos = CursosMateria.Where(x => x.Materia.Id == Materia.Id).ToList();

                    foreach (var cur in Cursos)
                    {
                        cbxComisiones.Items.Add(cur.Comision.NroComision);
                    }
                }
            }
        }

        private void cbxComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxComisiones.SelectedItem != null)
            {
                var nro_com = Convert.ToInt32(cbxComisiones.SelectedItem.ToString());
                Comision = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nro_com, Plan.Especialidad);

                if (Materia != null && Comision != null)
                {
                    Curso = TPI.Negocio.Curso.BuscarCursoPorMateriaComision(Materia, Comision);

                    if (Curso != null)
                    {
                        string horario = $"{Curso.Dia} de {Curso.HoraInicio} a {Curso.HoraFin}";
                        lblHorarioCurso.Text = horario;
                        lblHorarioCurso.Visible = true;
                    }
                    if (Curso == null)
                    {
                        string horario = $"No existe el curso seleccionado";
                        lblHorarioCurso.Text = horario;
                        lblHorarioCurso.Visible = true;
                    }
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Usuario != null && Curso != null)
                {
                    if (Curso.Cupo > 0)
                    {
                        var cur = TPI.Negocio.Cursado.BuscarCursoPorUsuarioCurso(Usuario, Curso);

                        TPI.Entidades.Cursado cursado = TPI.Negocio.Cursado.Crear(Usuario, Curso, DateTime.Now);
                        if (cursado != null && cur == null)
                        {
                            // Actualizo el Cupo 
                            cursado.Curso.Cupo -= 1;
                            TPI.Negocio.Curso.Cambiar(cursado.Curso);

                            // Registro la Inscripcion
                            TPI.Negocio.Cursado.Agregar(cursado);

                            MessageBox.Show("Inscripcion relizada con Exito!");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay cupos disponibles");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al solicitar inscribirse");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
