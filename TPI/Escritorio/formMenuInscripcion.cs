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
    public partial class formMenuInscripcion : Form
    {
        public formMenuInscripcion()
        {
            InitializeComponent();
        }

        private void formMenuInscripcion_Load(object sender, EventArgs e)
        {
            TPI.Datos.Especialidades.InicializarListaEspecialidades();
            foreach (var especialidad in TPI.Datos.Especialidades.GetEspecialidades())
            {
                listBoxEspecialidades.Items.Add(especialidad.descEspec);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
