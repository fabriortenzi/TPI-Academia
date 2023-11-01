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
    public partial class formCargarNotas : Form
    {
        private TPI.Entidades.Usuario Profesor;

        public formCargarNotas(TPI.Entidades.Usuario _profesor)
        {
            InitializeComponent();
            Profesor = _profesor;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cicloLectivo;
            string cicloLectIng = txtCicloLectivo.Text;

            try
            {
                cicloLectivo = Convert.ToInt32(cicloLectIng);
            }
            catch
            {
                MessageBox.Show("El Ciclo Lectivo debe ser un Año. Ej: 2023", "Cargar Notas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var profCursos = TPI.Negocio.ProfesorCurso.BuscarPorUsuarioCicloLectivo(Profesor.Legajo, cicloLectivo);
            cbxCursos.DisplayMember = "Text";
            cbxCursos.ValueMember = "Value";

            var items = new List<Object>();

            foreach (var profCurso in profCursos)
            {
                items.Add(new { Text = $"{profCurso.Curso.Materia.Descripcion} - {profCurso.Curso.Comision.NroComision}", Value = profCurso.Curso.Id });
            }

            cbxCursos.DataSource = items;
            cbxCursos.Enabled = true;
            cbxCursos.SelectedIndex = -1;
        }

        private void cbxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdCurso = Convert.ToInt32(cbxCursos.SelectedValue);
            var cursados = TPI.Negocio.Cursado.BuscarCursadosPorCurso(IdCurso)
                .OrderBy(c => c.Usuario.Persona.Apellido)
                .ThenBy(c => c.Usuario.Persona.Nombre)
                .ToList();
            dgvCursados.DataSource = cursados;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow cursados in dgvCursados.Rows)
            {
                int id = Convert.ToInt32(cursados.Cells["Id"].Value.ToString());
                var cursado = TPI.Negocio.Cursado.GetOne(id);

                int nota = 0;
                try
                {
                    nota = Convert.ToInt32(cursados.Cells["NotaFinal"].Value.ToString());
                    bool validar_nota = TPI.Negocio.Cursado.ValidarNota(nota);
                    if (validar_nota == false)
                    {
                        MessageBox.Show($"La nota de {cursados.Cells["Usuario"].Value}" +
                                         "debe ser un numero entero entre 1 y 10", "Cargar Notas", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return;
                    }
                }
                catch
                {
                    MessageBox.Show($"La nota de {cursados.Cells["Usuario"].Value}" +
                                     "debe ser un numero entero entre 1 y 10", "Cargar Notas", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;
                }

                cursado.NotaFinal = nota;
                TPI.Negocio.Cursado.Cambiar(cursado);
            }

            MessageBox.Show("Notas agregadas exitosamente!", "Cargar Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
