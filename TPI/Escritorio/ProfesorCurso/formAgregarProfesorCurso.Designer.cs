namespace Escritorio.ProfesorCurso
{
    partial class formAgregarProfesorCurso
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
            btnAgregar = new System.Windows.Forms.Button();
            txtIdMateria = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtLegajo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtAnio = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtCargo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(19, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(144, 232);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new System.Drawing.Point(85, 78);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new System.Drawing.Size(100, 23);
            txtIdMateria.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "idMateria:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(85, 32);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(100, 23);
            txtLegajo.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 9;
            label1.Text = "Legajo:";
            // 
            // txtAnio
            // 
            txtAnio.Location = new System.Drawing.Point(85, 127);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new System.Drawing.Size(100, 23);
            txtAnio.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(45, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 16;
            label3.Text = "Año:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 173);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new System.Drawing.Point(85, 170);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new System.Drawing.Size(100, 23);
            txtCargo.TabIndex = 19;
            // 
            // formAgregarProfesorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(245, 281);
            Controls.Add(txtCargo);
            Controls.Add(label4);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtIdMateria);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "formAgregarProfesorCurso";
            Text = "formProfesorCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargo;
    }
}