using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Datos;

namespace Escritorio.Materia
{
    public partial class formMostrarMateria : Form
    {
        public TPI.Entidades.Materia? Materia;
        public TPI.Entidades.Plan? Plan;
        public formMostrarMateria(TPI.Entidades.Materia materia)
        {
            Materia = TPI.Negocio.Materia.GetOne(materia.Id);

            Plan = TPI.Negocio.Plan.GetOne(Materia.Plan.Id);

            InitializeComponent();
        }

        private void formMostrarMateria_Load(object sender, EventArgs e)
        {
            lblMateria.Text = Materia.Descripcion;
            lblEspecialidad.Text = Plan.Especialidad.Descripcion;
            lblPlan.Text = Plan.Anio.ToString();
            lblHorasSemanales.Text = Materia.HorasSemanales.ToString();
            lblHorasTotales.Text = Materia.HorasTotales.ToString();

        }
    }
}
