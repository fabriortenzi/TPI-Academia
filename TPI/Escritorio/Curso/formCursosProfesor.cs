using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Curso
{
    public partial class formCursosProfesor : Form
    {
        private TPI.Entidades.Usuario Usuario;

        public formCursosProfesor(TPI.Entidades.Usuario _usuario)
        {
            InitializeComponent();
            Usuario = _usuario;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCursosProfesor_Load(object sender, EventArgs e)
        {
            lblTitulo.Text += $" {DateTime.Now.Year}";
            dgvProfCursos.DataSource = TPI.Negocio.ProfesorCurso.BuscarPorUsuario(Usuario)
                                        .Where(pc => pc.Curso.CicloLectivo == DateTime.Now.Year)
                                        .ToList();
        }
    }
}
