using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Escritorio.Reportes
{
    public partial class formReporteCurso : Form
    {
        public formReporteCurso()
        {
            InitializeComponent();
        }

        private void CargarDS() 
        {
            var dsCurso = new dsCursoReporte();
            try { 
            foreach (var curso in TPI.Negocio.Curso.GetAll()) 
            {
                    dsCursoReporte.CursosRow row = dsCurso.Cursos.NewCursosRow();
                    row.Id = curso.Id;
                    row.Cupo = curso.Cupo;
                    row.Dia = curso.Dia;
                    row.Ciclo = curso.CicloLectivo;
                    row.HoraInicio = curso.HoraInicio;
                    row.HoraFin = curso.HoraFin;
                    row.Materia = curso.Materia.Descripcion;
                    row.Comision = curso.Comision.NroComision.ToString();
                    row.CantAlumnosInsc = TPI.Negocio.Cursado.BuscarCantAlumnosInsc(curso);
                    row.CantProfesoresInsc= TPI.Negocio.ProfesorCurso.BuscarCantProfesoresInsc(curso);
                    row.PorceAprobado = TPI.Negocio.Cursado.PorceAprobado(curso);
                    row.PorceDesAprobado = TPI.Negocio.Cursado.DesAprobado(curso);
                    dsCurso.Cursos.AddCursosRow(row);
                }
                rvwReporte.LocalReport.DataSources.Clear();
                rvwReporte.LocalReport.DataSources.Add(new ReportDataSource("dsCursoReporte", dsCurso.Tables["Cursos"]));
                rvwReporte.RefreshReport();
            }
            catch 
            {
                MessageBox.Show("Error al encontrar cursos");
            }
        }

        private void formReporteCurso_Load(object sender, EventArgs e)
        {
            CargarDS();
        }
    }
}
