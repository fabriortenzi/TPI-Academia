using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Comision
{
    public partial class formMostrarComision : Form
    {
        private TPI.Entidades.Comision comision { get; set; }
        public formMostrarComision(TPI.Entidades.Comision com)
        {
            comision = com;
            InitializeComponent();
            
        }

        private void formMostrarComision_Load(object sender, EventArgs e)
        {
            lblComison.Text = comision.NroComision.ToString();
            lblEspecialidad.Text = comision.Especialidad.Descripcion;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            formModificarComision formModificarComision = new formModificarComision(comision);
            formModificarComision.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
