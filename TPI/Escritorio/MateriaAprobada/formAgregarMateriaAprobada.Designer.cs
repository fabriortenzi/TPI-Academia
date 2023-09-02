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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.cbxAlumno = new System.Windows.Forms.ComboBox();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(199, 199);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(27, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // nudNota
            // 
            this.nudNota.Enabled = false;
            this.nudNota.Location = new System.Drawing.Point(108, 134);
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(37, 23);
            this.nudNota.TabIndex = 8;
            // 
            // cbxAlumno
            // 
            this.cbxAlumno.Enabled = false;
            this.cbxAlumno.FormattingEnabled = true;
            this.cbxAlumno.Location = new System.Drawing.Point(108, 85);
            this.cbxAlumno.Name = "cbxAlumno";
            this.cbxAlumno.Size = new System.Drawing.Size(127, 23);
            this.cbxAlumno.TabIndex = 9;
            this.cbxAlumno.SelectedIndexChanged += new System.EventHandler(this.cbxAlumno_SelectedIndexChanged);
            // 
            // cbxMateria
            // 
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(108, 45);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(127, 23);
            this.cbxMateria.TabIndex = 10;
            this.cbxMateria.SelectedIndexChanged += new System.EventHandler(this.cbxMateria_SelectedIndexChanged);
            // 
            // formAgregarMateriaAprobada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 234);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.cbxAlumno);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formAgregarMateriaAprobada";
            this.Text = "formAgregarMateriaAprobada";
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.ComboBox cbxAlumno;
        private System.Windows.Forms.ComboBox cbxMateria;
    }
}