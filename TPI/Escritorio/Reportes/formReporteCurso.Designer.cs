namespace Escritorio.Reportes
{
    partial class formReporteCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rvwReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // rvwReporte
            // 
            rvwReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            rvwReporte.Location = new System.Drawing.Point(0, 0);
            rvwReporte.Name = "rvwReporte";
            rvwReporte.ServerReport.BearerToken = null;
            rvwReporte.Size = new System.Drawing.Size(800, 450);
            rvwReporte.TabIndex = 0;
            // 
            // formReporteCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(rvwReporte);
            Name = "formReporteCurso";
            Text = "formReporteCurso";
            Load += formReporteCurso_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwReporte;
    }
}