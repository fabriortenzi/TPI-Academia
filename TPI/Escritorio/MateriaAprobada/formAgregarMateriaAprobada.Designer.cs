namespace Escritorio.MateriaAprobada
{
    partial class formAgregarMateriaAprobada
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
            txtLegajo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtIdMateria = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnAgregar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            nudNota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(57, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(108, 45);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(127, 23);
            txtLegajo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "idMateria:";
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new System.Drawing.Point(108, 91);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new System.Drawing.Size(127, 23);
            txtIdMateria.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(66, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Nota:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(199, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(27, 199);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nudNota
            // 
            nudNota.Location = new System.Drawing.Point(108, 134);
            nudNota.Name = "nudNota";
            nudNota.Size = new System.Drawing.Size(37, 23);
            nudNota.TabIndex = 8;
            // 
            // formMateriaAprobada
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(297, 234);
            Controls.Add(nudNota);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(txtIdMateria);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "formMateriaAprobada";
            Text = "formAgregarMateriaAprobada";
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudNota;
    }
}