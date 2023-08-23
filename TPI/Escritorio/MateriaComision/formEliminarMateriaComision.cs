using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.MateriaComision
{
    public partial class formEliminarMateriaComision : Form
    {
        public formEliminarMateriaComision()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf == DialogResult.Yes)
            {
                int id_materia = int.Parse(txtIdMateria.Text);
            int id_comision = int.Parse(txtIdComision.Text);
            int id_especialidad = int.Parse(txtidEspecialidad.Text);

            TPI.Entidades.MateriaComision materia_comision = TPI.Negocio.MateriaComision.GetMateriaComision(id_materia, id_especialidad, id_comision);
            TPI.Negocio.MateriaComision.Eliminar(materia_comision);
            }
            else { this.Close(); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
