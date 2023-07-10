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
            try
            {
                int dni = Convert.ToInt32(this.txtDNI.Text);
                int legajo = 0;
                if (this.txtLegajo.Text != "")
                {
                    legajo = Convert.ToInt32(this.txtLegajo.Text);
                }
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                string nombreUsuario = this.txtNomUsuario.Text;
                string contraseña = this.txtContraseña.Text;
                string confirmarContraseña = this.txtConfContr.Text;
                bool rdioAlumno = this.rdioAlumno.Checked;
                bool rdioProfesor = this.rdioProfesor.Checked;
                bool rdioAdmin = this.rdioAdmin.Checked;


                if (contraseña != confirmarContraseña)
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden", "Alta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rdioAlumno)
                    {
                        TPI.Negocio.Alumno.CrearAlumno(dni, legajo, nombre, apellido, nombreUsuario, contraseña);
                        MessageBox.Show("Alumno creado exitosamente!", "Alta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (rdioProfesor)
                    {
                        TPI.Negocio.Profesor.CrearProfesor(dni, legajo, nombre, apellido, nombreUsuario, contraseña);
                        MessageBox.Show("Profesor creado exitosamente!", "Alta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {                        
                        TPI.Negocio.Administrativo.CrearAdministrativo(dni, nombre, apellido, nombreUsuario, contraseña);
                        MessageBox.Show("Administrativo creado exitosamente!", "Alta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Algunos campos quedaron en blanco", "Alta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void radioButton1_Enter(object sender, EventArgs e)
        {
            lblLegajo.Visible = true;
            txtLegajo.Visible = true;
            lblDNI.Visible = true;
            txtDNI.Visible = true;
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblApellido.Visible = true;
            txtApellido.Visible = true;
            lblNomUsuario.Visible = true;
            txtNomUsuario.Visible = true;
            lblContraseña.Visible = true;
            txtContraseña.Visible = true;
            lblConfContr.Visible = true;
            txtConfContr.Visible = true;
        }

        private void rdioAlumno_Leave(object sender, EventArgs e)
        {
            lblLegajo.Visible = false;
            txtLegajo.Visible = false;
            lblDNI.Visible = false;
            txtDNI.Visible = false;
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            lblApellido.Visible = false;
            txtApellido.Visible = false;
            lblNomUsuario.Visible = false;
            txtNomUsuario.Visible = false;
            lblContraseña.Visible = false;
            txtContraseña.Visible = false;
            lblConfContr.Visible = false;
            txtConfContr.Visible = false;
        }

        private void rdioProfesor_Enter(object sender, EventArgs e)
        {
            lblLegajo.Visible = true;
            txtLegajo.Visible = true;
            lblDNI.Visible = true;
            txtDNI.Visible = true;
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblApellido.Visible = true;
            txtApellido.Visible = true;
            lblNomUsuario.Visible = true;
            txtNomUsuario.Visible = true;
            lblContraseña.Visible = true;
            txtContraseña.Visible = true;
            lblConfContr.Visible = true;
            txtConfContr.Visible = true;
        }

        private void rdioProfesor_Leave(object sender, EventArgs e)
        {
            lblLegajo.Visible = false;
            txtLegajo.Visible = false;
            lblDNI.Visible = false;
            txtDNI.Visible = false;
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            lblApellido.Visible = false;
            txtApellido.Visible = false;
            lblNomUsuario.Visible = false;
            txtNomUsuario.Visible = false;
            lblContraseña.Visible = false;
            txtContraseña.Visible = false;
            lblConfContr.Visible = false;
            txtConfContr.Visible = false;
        }

        private void rdioAdmin_Leave(object sender, EventArgs e)
        {
            lblDNI.Visible = false;
            txtDNI.Visible = false;
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            lblApellido.Visible = false;
            txtApellido.Visible = false;
            lblNomUsuario.Visible = false;
            txtNomUsuario.Visible = false;
            lblContraseña.Visible = false;
            txtContraseña.Visible = false;
            lblConfContr.Visible = false;
            txtConfContr.Visible = false;
        }

        private void rdioAdmin_Enter(object sender, EventArgs e)
        {
            lblLegajo.Visible = false;
            txtLegajo.Visible = false;
            lblDNI.Visible = true;
            txtDNI.Visible = true;
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblApellido.Visible = true;
            txtApellido.Visible = true;
            lblNomUsuario.Visible = true;
            txtNomUsuario.Visible = true;
            lblContraseña.Visible = true;
            txtContraseña.Visible = true;
            lblConfContr.Visible = true;
            txtConfContr.Visible = true;
        }

        private void rdioAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAlumno.Checked)
            {
                lblLegajo.Visible = true;
                txtLegajo.Visible = true;
                lblDNI.Visible = true;
                txtDNI.Visible = true;
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lblApellido.Visible = true;
                txtApellido.Visible = true;
                lblNomUsuario.Visible = true;
                txtNomUsuario.Visible = true;
                lblContraseña.Visible = true;
                txtContraseña.Visible = true;
                lblConfContr.Visible = true;
                txtConfContr.Visible = true;
            }
            else
            {
                lblLegajo.Visible = false;
                txtLegajo.Visible = false;
                lblDNI.Visible = false;
                txtDNI.Visible = false;
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lblApellido.Visible = false;
                txtApellido.Visible = false;
                lblNomUsuario.Visible = false;
                txtNomUsuario.Visible = false;
                lblContraseña.Visible = false;
                txtContraseña.Visible = false;
                lblConfContr.Visible = false;
                txtConfContr.Visible = false;
            }
        }

        private void rdioProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioProfesor.Checked)
            {
                lblLegajo.Visible = true;
                txtLegajo.Visible = true;
                lblDNI.Visible = true;
                txtDNI.Visible = true;
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lblApellido.Visible = true;
                txtApellido.Visible = true;
                lblNomUsuario.Visible = true;
                txtNomUsuario.Visible = true;
                lblContraseña.Visible = true;
                txtContraseña.Visible = true;
                lblConfContr.Visible = true;
                txtConfContr.Visible = true;
            }
            else
            {
                lblLegajo.Visible = false;
                txtLegajo.Visible = false;
                lblDNI.Visible = false;
                txtDNI.Visible = false;
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lblApellido.Visible = false;
                txtApellido.Visible = false;
                lblNomUsuario.Visible = false;
                txtNomUsuario.Visible = false;
                lblContraseña.Visible = false;
                txtContraseña.Visible = false;
                lblConfContr.Visible = false;
                txtConfContr.Visible = false;
            }
        }

        private void rdioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAdmin.Checked)
            {
                lblLegajo.Visible = false;
                txtLegajo.Visible = false;
                lblDNI.Visible = true;
                txtDNI.Visible = true;
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lblApellido.Visible = true;
                txtApellido.Visible = true;
                lblNomUsuario.Visible = true;
                txtNomUsuario.Visible = true;
                lblContraseña.Visible = true;
                txtContraseña.Visible = true;
                lblConfContr.Visible = true;
                txtConfContr.Visible = true;
            }
            else
            {
                lblDNI.Visible = false;
                txtDNI.Visible = false;
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lblApellido.Visible = false;
                txtApellido.Visible = false;
                lblNomUsuario.Visible = false;
                txtNomUsuario.Visible = false;
                lblContraseña.Visible = false;
                txtContraseña.Visible = false;
                lblConfContr.Visible = false;
                txtConfContr.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
