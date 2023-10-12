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
            dgvInscripciones.DataSource = TPI.Negocio.Cursado.BuscarCursadosPorUsuarioAño(Usuario, DateTime.Now.Year);
            if(TPI.Negocio.Cursado.BuscarCursadosPorUsuarioAño(Usuario, DateTime.Now.Year) == null) { MessageBox.Show("No hay inscripciones para eliminar"); }
        }

        private void dgvInscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvInscripciones.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Eliminar")
            {
                
                try {
                    var idInscripcion = int.Parse(dgvInscripciones.Rows[e.RowIndex].Cells[1].Value.ToString());
                    TPI.Negocio.Cursado.Eliminar(TPI.Negocio.Cursado.GetOne(idInscripcion));
                    MessageBox.Show("Inscripcion elimnada");
                    dgvInscripciones.DataSource = TPI.Negocio.Cursado.BuscarCursadosPorUsuarioAño(Usuario, DateTime.Now.Year);
                }
                
                catch
                {
                    MessageBox.Show("Error al eliminar Inscripcion");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
