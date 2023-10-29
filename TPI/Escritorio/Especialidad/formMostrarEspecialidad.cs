using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Especialidad
{
    public partial class formMostrarEspecialidad : Form
    {
        private TPI.Entidades.Especialidad Especialidad;
        public formMostrarEspecialidad(TPI.Entidades.Especialidad especialidad)
        {
            Especialidad = especialidad;
            InitializeComponent();
        }

        private void formMostrarEspecialidad_Load(object sender, EventArgs e)
        {
            lblId.Text = Especialidad.Id.ToString();
            lblDesc.Text = Especialidad.Descripcion;
        }
    }
}
