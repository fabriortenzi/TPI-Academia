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
    public partial class formConsultarMateriaAprobada : Form
    {
        public formConsultarMateriaAprobada()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id_materia = int.Parse(txtIdMateria.Text);
            int legajo = int.Parse(txtLegajo.Text);
            TPI.Entidades.MateriaAprobada materia_aprobada;
            materia_aprobada = TPI.Negocio.MateriaAprobada.GetMateriaAprobada(legajo, id_materia);
            formMostrarMateriaAprobada frmMostrarMateriaAprobada = new formMostrarMateriaAprobada(materia_aprobada);
            frmMostrarMateriaAprobada.Show();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
