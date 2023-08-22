namespace Escritorio.ProfesorCurso
{
    partial class formEliminarProfesorCurso
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
            txtAnio = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            txtIdMateria = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtLegajo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtAnio
            // 
            txtAnio.Location = new System.Drawing.Point(88, 124);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new System.Drawing.Size(100, 23);
            txtAnio.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(48, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 26;
            label3.Text = "Año:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(22, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(147, 229);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new System.Drawing.Point(88, 75);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new System.Drawing.Size(100, 23);
            txtIdMateria.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 22;
            label2.Text = "idMateria:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(88, 29);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(100, 23);
            txtLegajo.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 20;
            label1.Text = "Legajo:";
            // 
            // formEliminarProfesorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(245, 281);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdMateria);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "formEliminarProfesorCurso";
            Text = "formEliminarProfesorCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
    }
}