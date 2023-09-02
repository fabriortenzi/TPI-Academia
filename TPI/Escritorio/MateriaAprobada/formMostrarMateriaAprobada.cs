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
    public partial class formMostrarMateriaAprobada : Form
    {
        public TPI.Entidades.MateriaAprobada materiaAprobada;
        public formMostrarMateriaAprobada(TPI.Entidades.MateriaAprobada materia_aprobada)
        {
            InitializeComponent();
            lblIdMateriaShow.Text = materia_aprobada.idMateria.ToString();
            lblLegajoShow.Text = materia_aprobada.Legajo.ToString();
            lblNotaShow.Text = materia_aprobada.Nota.ToString();
            materiaAprobada = materia_aprobada;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formModificarMateriaAprobada frmModificarMateriaAprobada = new formModificarMateriaAprobada(materiaAprobada);
            frmModificarMateriaAprobada.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
