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
    public partial class formConsultarMateriaComision : Form
    {
        public formConsultarMateriaComision()
        {
            InitializeComponent();
            cargar_cbxes();
        }


        private void cargar_cbxes()
        {
            List<TPI.Entidades.Materia> materias = TPI.Negocio.Materia.GetAll();
            List<TPI.Entidades.Comision> comisiones = TPI.Negocio.Comision.GetAll();

            foreach (TPI.Entidades.Materia m in materias) { cbxMateria.Items.Add(m.descMateria); }
            foreach (TPI.Entidades.Comision c in comisiones) { cbxComision.Items.Add(c.IdCom + " " + c.Especialidad.descEspec); }

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string desc_materia = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);
            string id_desc_esp = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);

            TPI.Entidades.Comision comision = TPI.Negocio.Comision.GetComisionPorIdyDescEsp(id_desc_esp);
            TPI.Entidades.Materia materia = TPI.Negocio.Materia.GetMateriaPorDesc(desc_materia);

            TPI.Entidades.MateriaComision materia_comision = TPI.Negocio.MateriaComision.GetMateriaComision(materia.idMateria, comision.Especialidad.idEspec, comision.IdCom);

            formMostrarMateriaComision frmMostrarMateriaComision = new formMostrarMateriaComision(materia_comision);
            frmMostrarMateriaComision.Show();

        }
    }
}
