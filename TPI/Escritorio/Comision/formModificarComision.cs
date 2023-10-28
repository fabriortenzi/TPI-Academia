using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Escritorio.Comision
{
    public partial class formModificarComision : Form
    {
        private TPI.Entidades.Especialidad Especialidad;
        private TPI.Entidades.Comision comision;
        public formModificarComision(TPI.Entidades.Comision com)
        {
            comision = com;
            InitializeComponent();
        }

        private void formModificarComision_Load(object sender, EventArgs e)
        {
            foreach (var esp in TPI.Negocio.Especialidad.GetAllEspecialidades())
            {
                cbxEspecialidad.Items.Add(esp.Descripcion);


            }

            foreach (var item in cbxEspecialidad.Items) { 

            if (item.ToString() == comision.Especialidad.Descripcion)
            {
                    cbxEspecialidad.SelectedItem = item;
             }
            }

            txtNroCom.Text = comision.NroComision.ToString();
            
        }

        private void cbxEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string descEspecSelecc = cbxEspecialidad.SelectedItem.ToString();
            Especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(descEspecSelecc);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int nroCom = 0;
            try
            {
                nroCom = Convert.ToInt32(txtNroCom.Text);
            }
            catch
            {
                MessageBox.Show("El nro de Comision debe ser entero");
                return;
            }

            if (nroCom != 0)
            {
                
                try
                {
                    TPI.Negocio.Comision.Cambiar(comision, nroCom, Especialidad);
                    MessageBox.Show("Modificada con exito!");
                   this.Close();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Error");
                    return;
                }
            }
        }
    }
}
