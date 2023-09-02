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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdMateriaShow = new System.Windows.Forms.Label();
            this.lblLegajoShow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotaShow = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "idMateria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Legajo:";
            // 
            // lblIdMateriaShow
            // 
            this.lblIdMateriaShow.AutoSize = true;
            this.lblIdMateriaShow.Location = new System.Drawing.Point(247, 55);
            this.lblIdMateriaShow.Name = "lblIdMateriaShow";
            this.lblIdMateriaShow.Size = new System.Drawing.Size(86, 15);
            this.lblIdMateriaShow.TabIndex = 19;
            this.lblIdMateriaShow.Text = "IdMateriaShow";
            // 
            // lblLegajoShow
            // 
            this.lblLegajoShow.AutoSize = true;
            this.lblLegajoShow.Location = new System.Drawing.Point(247, 105);
            this.lblLegajoShow.Name = "lblLegajoShow";
            this.lblLegajoShow.Size = new System.Drawing.Size(71, 15);
            this.lblLegajoShow.TabIndex = 20;
            this.lblLegajoShow.Text = "LegajoShow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nota:";
            // 
            // lblNotaShow
            // 
            this.lblNotaShow.AutoSize = true;
            this.lblNotaShow.Location = new System.Drawing.Point(247, 160);
            this.lblNotaShow.Name = "lblNotaShow";
            this.lblNotaShow.Size = new System.Drawing.Size(62, 15);
            this.lblNotaShow.TabIndex = 22;
            this.lblNotaShow.Text = "NotaShow";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(37, 235);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(410, 235);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // formMostrarMateriaAprobada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 284);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblNotaShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLegajoShow);
            this.Controls.Add(this.lblIdMateriaShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formMostrarMateriaAprobada";
            this.Text = "formMostrarMateriaAprobada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdMateriaShow;
        private System.Windows.Forms.Label lblLegajoShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNotaShow;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
    }
}