using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.MateriaComision
{
    public partial class formAgregarMateriaComision : Form
    {
        public formAgregarMateriaComision()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TPI.Entidades.MateriaComision materia_comision = new TPI.Entidades.MateriaComision();
            materia_comision.IdEspecialidad = int.Parse(txtidEspecialidad.Text);
            materia_comision.idMateria = int.Parse(txtIdMateria.Text);
            materia_comision.IdCom = int.Parse(txtIdComision.Text);
            materia_comision.Cupo = (int)nudCupo.Value;
            materia_comision.dia = (int)nudDS.Value;

            TimeSpan hora_ini = TimeSpan.TryParse(mtbHora_ini.Text, out TimeSpan valorTimeSpan) ? valorTimeSpan : TimeSpan.Zero;
            materia_comision.hora_ini = hora_ini;
            TimeSpan hora_fin = TimeSpan.TryParse(mtbHora_fin.Text, out TimeSpan valorTimeSpan2) ? valorTimeSpan2 : TimeSpan.Zero;
            materia_comision.hora_ini = hora_fin;

            TPI.Negocio.MateriaComision.Agregar(materia_comision);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
