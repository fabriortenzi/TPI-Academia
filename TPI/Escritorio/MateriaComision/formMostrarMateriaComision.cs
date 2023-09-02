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
    public partial class formMostrarMateriaComision : Form
    {
        private TPI.Entidades.MateriaComision? materiaComision;
        public formMostrarMateriaComision(TPI.Entidades.MateriaComision materia_comision)
        {
            InitializeComponent();

            lblComision.Text =materia_comision.IdCom.ToString();
            lblMateria.Text = materia_comision.Materia.descMateria;
            lblCupo.Text = materia_comision.Cupo.ToString();
            lblDiaSemana.Text = materia_comision.dia.ToString();
            lblHoraini.Text = materia_comision.hora_ini.ToString();
            lblHorafin.Text = materia_comision.hora_fin.ToString();

            materiaComision = materia_comision;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formModificarMateriaComision frmModificarMateriaComision = new formModificarMateriaComision(materiaComision);
            frmModificarMateriaComision.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
