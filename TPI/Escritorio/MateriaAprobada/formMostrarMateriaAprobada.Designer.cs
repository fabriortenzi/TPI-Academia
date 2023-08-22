namespace Escritorio.MateriaAprobada
{
    partial class formMostrarMateriaAprobada
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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblIdMateriaShow = new System.Windows.Forms.Label();
            lblLegajoShow = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblNotaShow = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(152, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 18;
            label2.Text = "idMateria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(167, 105);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 16;
            label1.Text = "Legajo:";
            // 
            // lblIdMateriaShow
            // 
            lblIdMateriaShow.AutoSize = true;
            lblIdMateriaShow.Location = new System.Drawing.Point(247, 55);
            lblIdMateriaShow.Name = "lblIdMateriaShow";
            lblIdMateriaShow.Size = new System.Drawing.Size(86, 15);
            lblIdMateriaShow.TabIndex = 19;
            lblIdMateriaShow.Text = "IdMateriaShow";
            // 
            // lblLegajoShow
            // 
            lblLegajoShow.AutoSize = true;
            lblLegajoShow.Location = new System.Drawing.Point(247, 105);
            lblLegajoShow.Name = "lblLegajoShow";
            lblLegajoShow.Size = new System.Drawing.Size(71, 15);
            lblLegajoShow.TabIndex = 20;
            lblLegajoShow.Text = "LegajoShow";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(167, 160);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 15);
            label3.TabIndex = 21;
            label3.Text = "Nota:";
            // 
            // lblNotaShow
            // 
            lblNotaShow.AutoSize = true;
            lblNotaShow.Location = new System.Drawing.Point(247, 160);
            lblNotaShow.Name = "lblNotaShow";
            lblNotaShow.Size = new System.Drawing.Size(62, 15);
            lblNotaShow.TabIndex = 22;
            lblNotaShow.Text = "NotaShow";
            // 
            // formMostrarMateriaAprobada
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(517, 284);
            Controls.Add(lblNotaShow);
            Controls.Add(label3);
            Controls.Add(lblLegajoShow);
            Controls.Add(lblIdMateriaShow);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formMostrarMateriaAprobada";
            Text = "formMostrarMateriaAprobada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdMateriaShow;
        private System.Windows.Forms.Label lblLegajoShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNotaShow;
    }
}