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
            cargar_cbxes();
        }

        private void cargar_cbxes()
        {
            List<TPI.Entidades.Materia> materias = TPI.Negocio.Materia.GetAll();
            List<TPI.Entidades.Comisiones> comisiones = TPI.Negocio.Comision.GetAll();

            foreach (TPI.Entidades.Materia m in materias) { cbxMateria.Items.Add(m.descMateria); }
            foreach (TPI.Entidades.Comisiones c in comisiones) { cbxComision.Items.Add(c.IdCom + " " + c.Especialidad.descEspec); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf == DialogResult.Yes)
            {

                string desc_materia = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);
                string id_desc_esp = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);

                TPI.Entidades.Comisiones comision = TPI.Negocio.Comision.GetComisionPorIdyDescEsp(id_desc_esp);
                TPI.Entidades.Materia materia = TPI.Negocio.Materia.GetMateriaPorDesc(desc_materia);

                int id_materia = materia.idMateria;
                int id_comision = comision.IdCom;
                int id_especialidad = comision.Especialidad.idEspec;

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
