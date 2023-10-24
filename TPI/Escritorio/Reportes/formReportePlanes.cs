using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Reportes
{
    public partial class formReportePlanes : Form
    {
        public formReportePlanes()
        {
            InitializeComponent();
        }

        private void formReportePlanes_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = @"TPI\Escritorio\Reportes\reportePlanes.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
