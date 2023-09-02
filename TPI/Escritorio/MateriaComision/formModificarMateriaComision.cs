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
    public partial class formModificarMateriaComision : Form
    {
        private TPI.Entidades.MateriaComision materiaComision;
        public formModificarMateriaComision(TPI.Entidades.MateriaComision materia_comision)
        {
            InitializeComponent();

            lblMateria.Text = materia_comision.Materia.descMateria;
            lblComision.Text = materia_comision.Comisiones.IdCom.ToString();
            materiaComision = materia_comision;

        }

      


        private void btnModificar_Click(object sender, EventArgs e)
        {

            TimeSpan hora_ini = TimeSpan.TryParse(mtbHora_ini.Text, out TimeSpan valorTimeSpan) ? valorTimeSpan : TimeSpan.Zero;
            
            TimeSpan hora_fin = TimeSpan.TryParse(mtbHora_fin.Text, out TimeSpan valorTimeSpan2) ? valorTimeSpan2 : TimeSpan.Zero;


            TPI.Negocio.MateriaComision.Cambiar(materiaComision, (int)nudCupo.Value, (int)nudDS.Value, hora_ini, hora_fin);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
