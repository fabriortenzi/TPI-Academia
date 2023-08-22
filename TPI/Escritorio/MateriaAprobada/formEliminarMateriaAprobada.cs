using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.MateriaAprobada
{
    public partial class formEliminarMateriaAprobada : Form
    {
        public formEliminarMateriaAprobada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf == DialogResult.Yes)
            {
                int legajo = int.Parse(txtLegajo.Text);
                int id_materia = int.Parse(txtIdMateria.Text);
                TPI.Entidades.MateriaAprobada materia_aprobada = TPI.Negocio.MateriaAprobada.GetMateriaAprobada(legajo, id_materia);
                TPI.Negocio.MateriaAprobada.Eliminar(materia_aprobada);
            }
            else { this.Close(); }
        }
    }
}
