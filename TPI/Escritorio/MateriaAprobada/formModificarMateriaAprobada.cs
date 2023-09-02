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
    public partial class formModificarMateriaAprobada : Form
    {

        private TPI.Entidades.MateriaAprobada? materiaAprobada;

        public formModificarMateriaAprobada(TPI.Entidades.MateriaAprobada materia_aprobada)
        {
            InitializeComponent();
            lblMateria.Text = materia_aprobada.Materia.descMateria;
            lblAlumno.Text = (materia_aprobada.Usuario.Persona.Nombre + " " + materia_aprobada.Usuario.Persona.Apellido);
            materiaAprobada = materia_aprobada;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int nota = (int)nudNota.Value;
            if (materiaAprobada != null) { 
            TPI.Negocio.MateriaAprobada.Cambiar(materiaAprobada, nota);
            
            MessageBox.Show("Modificacion Realizada", "Modificacion");
            }
            else { MessageBox.Show("Ocurrio un error al tratar de modificar la materia aprobada", "Error de Modificacion"); }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
