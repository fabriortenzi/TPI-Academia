using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Datos;

namespace Escritorio
{
    public partial class formConsultarDatosUsuario : Form
    {
        private TPI.Entidades.Usuario Usuario;
        private TPI.Entidades.Plan? Plan;

        public formConsultarDatosUsuario(TPI.Entidades.Usuario usuario)
        {
            InitializeComponent();
            Usuario = TPI.Negocio.Usuario.GetOne(usuario.Legajo);
            if (usuario.Plan != null)
            {
                Plan = TPI.Negocio.Plan.GetOne(usuario.Plan.Id);
            }

        }

        private void formConsultarDatosUsuario_Load(object sender, EventArgs e)
        {
            lblLegajo.Text = Usuario.Legajo.ToString();
            lblPersona.Text = $"{Usuario.NombreCompleto}";
            lblTipo.Text = Usuario.TipoDeUsuario.Descripcion;
            if (Usuario.Plan != null)
            {
                lblEspecialidad.Text = Plan.Especialidad.Descripcion;
                lblPlan.Text = Usuario.Plan.Anio.ToString();
            }
            else
            {
                lblEspecialidad.Text = "No posee";
                lblPlan.Text = "No posee";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
