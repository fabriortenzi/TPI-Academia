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
    public partial class formCrearComision : Form
    {
        private TPI.Entidades.Especialidad Especialidad;

        public formCrearComision()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int nroCom = 0;
            try
            {
                nroCom = Convert.ToInt32(txtNroCom.Text);
            }
            catch
            {
                MessageBox.Show("El nro de Comision debe ser entero", "Crear Comision", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            if (nroCom == 0) { MessageBox.Show("El id de comision invalido", "Crear Comision", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

            var com = TPI.Negocio.Comision.BuscarComisionPorNroEspecialidad(nroCom, Especialidad);


            if (nroCom != 0 && com == null)
            {
                var comision = TPI.Negocio.Comision.Crear(nroCom, Especialidad);
                try
                {
                    TPI.Negocio.Comision.Agregar(comision);
                    MessageBox.Show("Comision creada con exito!", "Crear Comision", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("La comision ya existe", "Crear Comision", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            else { MessageBox.Show("La comision ya existe", "Crear Comision", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

        private void formCrearComision_Load(object sender, EventArgs e)
        {
            foreach (var esp in TPI.Negocio.Especialidad.GetAllEspecialidades())
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }
        }

        private void cbxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descEspecSelecc = cbxEspecialidades.SelectedItem.ToString();
            Especialidad = TPI.Negocio.Especialidad.Getespecialidadpordesc(descEspecSelecc);
        }
    }
}
