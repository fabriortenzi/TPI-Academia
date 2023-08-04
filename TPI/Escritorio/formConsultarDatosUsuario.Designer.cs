namespace Escritorio
{
    partial class formConsultarDatosUsuario
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
            label1 = new System.Windows.Forms.Label();
            lblLegajo = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblEspecialidad = new System.Windows.Forms.Label();
            lblPlan = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(117, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Legajo: ";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new System.Drawing.Point(196, 66);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new System.Drawing.Size(59, 25);
            lblLegajo.TabIndex = 1;
            lblLegajo.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(72, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 25);
            label3.TabIndex = 2;
            label3.Text = "Especialidad: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(136, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Plan: ";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new System.Drawing.Point(196, 116);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(59, 25);
            lblEspecialidad.TabIndex = 4;
            lblEspecialidad.Text = "label5";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new System.Drawing.Point(196, 161);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(59, 25);
            lblPlan.TabIndex = 5;
            lblPlan.Text = "label6";
            // 
            // formConsultarDatosUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(374, 281);
            Controls.Add(lblPlan);
            Controls.Add(lblEspecialidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblLegajo);
            Controls.Add(label1);
            Name = "formConsultarDatosUsuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Consultar Datos";
            Load += formConsultarDatosUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblPlan;
    }
}