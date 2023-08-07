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
    public partial class formCrearCurso : Form
    {
        TPI.Entidades.Especialidad Especialidad;
        
        public formCrearCurso()
        {
            InitializeComponent();
        }

        private void formCrearCurso_Load(object sender, EventArgs e)
        {
            var especialidades = TPI.Negocio.Especialidad.GetAllEspecialidades();

            foreach (var esp in especialidades)
            {
                cbxEspecialidades.Items.Add(esp.descEspec);
            }
        }

        private void cbxEspecialidades_TextUpdate(object sender, EventArgs e)
        {
            var planesPorEspecialidad = TPI.Negocio.Plan.GetPlanesPorEspecialidad(Especialidad);
            
            cbxPlanes.Items.Add("");
        }
    }
}
