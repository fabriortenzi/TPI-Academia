using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Cursado
{
    public partial class formConsultarNotas : Form
    {
        private TPI.Entidades.Usuario Alumno;

        public formConsultarNotas(TPI.Entidades.Usuario _alumno)
        {
            InitializeComponent();
            Alumno = _alumno;
        }

        private void formConsultarNotas_Load(object sender, EventArgs e)
        {
            dgvCursados.DataSource = TPI.Negocio.Cursado.BuscarCursadosPorAlumno(Alumno.Legajo)
                                        .Where(c => c.NotaFinal != null).ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
