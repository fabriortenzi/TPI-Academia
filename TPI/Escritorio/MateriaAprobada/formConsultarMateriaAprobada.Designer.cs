namespace Escritorio.MateriaAprobada
{
    partial class formConsultarMateriaAprobada
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
            btnCancelar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtIdMateria = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtLegajo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(23, 233);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(398, 233);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new System.Drawing.Point(218, 82);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new System.Drawing.Size(127, 23);
            txtIdMateria.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(142, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "idMateria:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(218, 129);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(127, 23);
            txtLegajo.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(157, 132);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 9;
            label1.Text = "Legajo:";
            // 
            // formConsultarMateriaAprobada
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(517, 284);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdMateria);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "formConsultarMateriaAprobada";
            Text = "formConsultarMateriaAprobada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
    }
}