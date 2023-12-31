﻿using System;
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
    public partial class formEliminarInscripcion : Form
    {
        private TPI.Entidades.Usuario Usuario;
        public formEliminarInscripcion(TPI.Entidades.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        private void formEliminarInscripcion_Load(object sender, EventArgs e)
        {
            var cursados = TPI.Negocio.Cursado.BuscarCursadosPorUsuarioAño(Usuario, DateTime.Now.Year)
                            .Where(c => c.NotaFinal == null).ToList();

            if (cursados.Count == 0)
            {
                MessageBox.Show("No tienes inscripciones para eliminar", "Eliminar Inscripcion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            else
            {
                dgvInscripciones.DataSource = cursados;
            }
        }

        private void dgvInscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvInscripciones.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Eliminar")
            {
                try
                {
                    var idInscripcion = int.Parse(dgvInscripciones.Rows[e.RowIndex].Cells[1].Value.ToString());
                    TPI.Negocio.Cursado.Eliminar(TPI.Negocio.Cursado.GetOne(idInscripcion));
                    MessageBox.Show("Inscripcion elimnada", "Eliminar Inscripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvInscripciones.DataSource = TPI.Negocio.Cursado.BuscarCursadosPorUsuarioAño(Usuario, DateTime.Now.Year)
                                                    .Where(c => c.NotaFinal == null).ToList();
                }

                catch
                {
                    MessageBox.Show("Error al eliminar Inscripcion", "Eliminar Inscripcion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
