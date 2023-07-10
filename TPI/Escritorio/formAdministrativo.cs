using Escritorio.CRUD.Alumno;
using Escritorio.CRUD.Usuario;
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
    public partial class formAdministrativo : Form
    {
        public formAdministrativo()
        {
            InitializeComponent();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaUsuario crearAlumno = new();
            crearAlumno.Show();
        }

        private void formAdministrativo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            retrieveUsuarios retrieveUsuarios = new();
            retrieveUsuarios.Show();
        }
    }
}
