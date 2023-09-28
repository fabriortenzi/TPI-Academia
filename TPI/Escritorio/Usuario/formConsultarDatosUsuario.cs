using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class formConsultarDatosUsuario : Form
    {
        private TPI.Entidades.Usuario Usuario;

        public formConsultarDatosUsuario(TPI.Entidades.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        private void formConsultarDatosUsuario_Load(object sender, EventArgs e)
        {
            lblLegajo.Text = Usuario.Legajo.ToString();
            lblEspecialidad.Text = Usuario.Plan.Especialidad.Descripcion;
            lblPlan.Text = Usuario.Plan.Anio.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
