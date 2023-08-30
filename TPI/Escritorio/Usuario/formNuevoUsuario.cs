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
    public partial class formNuevoUsuario : Form
    {
        private TPI.Entidades.Persona? persona;
        public formNuevoUsuario()
        {
            InitializeComponent();
            var tiposDeUsuario = TPI.Negocio.TipoDeUsuario.GetAllTiposDeUsuario();

            foreach (var tipo in tiposDeUsuario)
            {
                cbxTiposDeUsuario.Items.Add(tipo.Descripcion);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {            
            string descripcionTipo = this.cbxTiposDeUsuario.GetItemText(this.cbxTiposDeUsuario.SelectedItem);
            string contraseña = txtContraseña.Text;
            string confContraseña = txtConfContraseña.Text;

            var tipoDeUsuario = TPI.Negocio.TipoDeUsuario.GetTipoUsuarioPorDecsripcion(descripcionTipo);

            if (descripcionTipo == "" || contraseña == "" || confContraseña == "")
            {
                MessageBox.Show("Algunos campos quedaron en blanco");
            }
            else if (contraseña == confContraseña)
            {
                var usuario = TPI.Negocio.Usuario.CrearUsuario(contraseña, persona, tipoDeUsuario);
                TPI.Negocio.Usuario.AgregarUsuario(usuario);

                // Si el usuario nuevo es un Alumno se abre el form para asignar plan de estudio
                if (descripcionTipo == "Alumno")
                {
                    formInscripcionPlan formInscripcionPlan = new(usuario);
                    formInscripcionPlan.Show();
                }
                else
                {
                    MessageBox.Show("Usuario creado con exito!");
                }

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni = 0;
            
            try
            {
                dni = Convert.ToInt32(txtDni.Text);
            }
            catch
            {
                MessageBox.Show("El DNI no puede contener letras");
                return;
            }

            var personaIngresada = TPI.Negocio.Persona.GetPersonaPorDni(dni);

            if (personaIngresada != null)
            {
                lblTitApeNom.Enabled = true;
                lblApellidoNombre.Text = personaIngresada.Apellido + ", " + personaIngresada.Nombre;
                lblApellidoNombre.Visible = true;
                lblApellidoNombre.Enabled = true;
                lblTipUsu.Enabled = true;
                cbxTiposDeUsuario.Enabled = true;
                lblCont.Enabled = true;
                txtContraseña.Enabled = true;
                lblConfCont.Enabled = true;
                txtConfContraseña.Enabled = true;
                btnCrear.Enabled = true;

                persona = personaIngresada;
            }
            else
            {
                lblTitApeNom.Enabled = false;
                lblApellidoNombre.Text = "";
                lblApellidoNombre.Visible = false;
                lblApellidoNombre.Enabled = false;
                lblTipUsu.Enabled = false;
                cbxTiposDeUsuario.Enabled = false;
                lblCont.Enabled = false;
                txtContraseña.Enabled = false;
                lblConfCont.Enabled = false;
                txtConfContraseña.Enabled = false;
                btnCrear.Enabled = false;

                MessageBox.Show("No se encontro la persona, intente nuevamente");
            }
        }
    }
}