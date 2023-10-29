using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Persona
{
    public partial class formMostrarPersona : Form
    {
        public TPI.Entidades.Persona Persona;
        public formMostrarPersona(TPI.Entidades.Persona persona)
        {
            Persona = persona;
            InitializeComponent();
        }

        private void formMostrarPersona_Load(object sender, EventArgs e)
        {
            lblDni.Text = Persona.Dni.ToString();
            lblNombre.Text = Persona.Nombre;
            lblApellido.Text = Persona.Apellido;
            lblDireccion.Text = Persona.Direccion;
            lblFechaNacimiento.Text = Persona.FechaNacimiento.ToString();
            lblTelefono.Text = Persona.Telefono;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO IMPLEMENTADO");
        }
    }
}
