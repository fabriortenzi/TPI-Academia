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
    public partial class formAgregarMateriaComision : Form
    {
        public formAgregarMateriaComision()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TPI.Entidades.MateriaComision materia_comision = new TPI.Entidades.MateriaComision();

            string desc_materia = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);
            string id_desc_esp = this.cbxMateria.GetItemText(this.cbxMateria.SelectedItem);

            TPI.Entidades.Comisiones comision = TPI.Negocio.Comision.GetComisionPorIdyDescEsp(id_desc_esp);
            TPI.Entidades.Materia materia = TPI.Negocio.Materia.GetMateriaPorDesc(desc_materia);




            materia_comision.IdEspecialidad = comision.Especialidad.idEspec;
            materia_comision.idMateria = materia.idMateria;
            materia_comision.IdCom = comision.IdCom;
            materia_comision.Cupo = (int)nudCupo.Value;
            materia_comision.dia = (int)nudDS.Value;

            TimeSpan hora_ini = TimeSpan.TryParse(mtbHora_ini.Text, out TimeSpan valorTimeSpan) ? valorTimeSpan : TimeSpan.Zero;
            materia_comision.hora_ini = hora_ini;
            TimeSpan hora_fin = TimeSpan.TryParse(mtbHora_fin.Text, out TimeSpan valorTimeSpan2) ? valorTimeSpan2 : TimeSpan.Zero;
            materia_comision.hora_ini = hora_fin;

            TPI.Negocio.MateriaComision.Agregar(materia_comision);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
