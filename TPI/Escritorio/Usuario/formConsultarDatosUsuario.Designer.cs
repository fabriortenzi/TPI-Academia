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
            btnAceptar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(159, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 29);
            label1.TabIndex = 0;
            label1.Text = "Legajo: ";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLegajo.Location = new System.Drawing.Point(240, 70);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new System.Drawing.Size(74, 29);
            lblLegajo.TabIndex = 1;
            lblLegajo.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(99, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(148, 29);
            label3.TabIndex = 2;
            label3.Text = "Especialidad: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(180, 165);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 29);
            label4.TabIndex = 3;
            label4.Text = "Plan: ";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEspecialidad.Location = new System.Drawing.Point(240, 120);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(74, 29);
            lblEspecialidad.TabIndex = 4;
            lblEspecialidad.Text = "label5";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPlan.Location = new System.Drawing.Point(240, 165);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(74, 29);
            lblPlan.TabIndex = 5;
            lblPlan.Text = "label6";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAceptar.Location = new System.Drawing.Point(148, 259);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(229, 48);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // formConsultarDatosUsuario
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnAceptar;
            ClientSize = new System.Drawing.Size(529, 337);
            Controls.Add(btnAceptar);
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
        private System.Windows.Forms.Button btnAceptar;
    }
}