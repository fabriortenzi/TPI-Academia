using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.CRUD.Alumno
{
    public partial class altaUsuario : Form
    {
        public altaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(this.txtDNI.Text);
            int legajo = Convert.ToInt32(this.txtLegajo.Text);
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string nombreUsuario = this.txtNomUsuario.Text;
            string contraseña = this.txtContraseña.Text;

            TPI.Negocio.Alumno.CrearAlumno(dni, legajo, nombre, apellido, nombreUsuario, contraseña);
        }
    }
}
