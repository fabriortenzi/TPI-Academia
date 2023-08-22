using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.MateriaAprobada
{
    public partial class formMostrarMateriaAprobada : Form
    {
        public formMostrarMateriaAprobada(TPI.Entidades.MateriaAprobada materia_aprobada)
        {
            InitializeComponent();
            lblIdMateriaShow.Text = materia_aprobada.idMateria.ToString();
            lblLegajoShow.Text = materia_aprobada.Legajo.ToString();
            lblNotaShow.Text = materia_aprobada.Nota.ToString();
        }
    }
}
