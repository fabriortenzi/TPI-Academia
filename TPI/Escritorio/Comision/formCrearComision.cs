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
            Dispose();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int idCom = 0;
            try
            {
                idCom = Convert.ToInt32(txtNroCom.Text);
            }
            catch
            {
                MessageBox.Show("El nro de Comision debe ser entero");
                return;
            }

            if (idCom != 0)
            {
                var comision = TPI.Negocio.Comision.Crear(idCom, Especialidad);
                try
                {
                    TPI.Negocio.Comision.Agregar(comision);
                    MessageBox.Show("Comision creada con exito!");
                    Dispose();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("La comision ya existe");
                    return;
                }
            }
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
