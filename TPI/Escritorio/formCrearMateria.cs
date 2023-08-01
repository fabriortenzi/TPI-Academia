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
    public partial class formCrearMateria : Form
    {
        public formCrearMateria()
        {
            InitializeComponent();
        }

        private void formCrearMateria_Load(object sender, EventArgs e)
        {
            TPI.Datos.Materia.inicializarMaterias();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string descMateria = (this.txtNombreMat.Text);
                int horasem = Convert.ToInt32(this.txtHorasSem.Text);
                int horasTot = Convert.ToInt32(this.txtHorasTot.Text);

                var Materia = TPI.Negocio.Materia.CrearMateria(descMateria, horasem, horasTot);

                TPI.Negocio.Materia.AgregaMateria(Materia);
                MessageBox.Show("Materia creada con exito!");

                this.Dispose();

            }
            catch
            {
                MessageBox.Show("Algunos campos son incorrectos o quedaron en blanco");
            }
        }

        private void txtHorasTot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorasSem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreMat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
