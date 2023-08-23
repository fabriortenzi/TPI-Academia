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
    public partial class formAgregarMateriaAprobada : Form
    {
        public formAgregarMateriaAprobada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TPI.Entidades.MateriaAprobada materia_aprobada = new TPI.Entidades.MateriaAprobada();
            materia_aprobada.idMateria = int.Parse(txtIdMateria.Text);
            materia_aprobada.Legajo = int.Parse(txtLegajo.Text);
            materia_aprobada.Nota = (int)nudNota.Value;
            TPI.Negocio.MateriaAprobada.Agregar(materia_aprobada);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
