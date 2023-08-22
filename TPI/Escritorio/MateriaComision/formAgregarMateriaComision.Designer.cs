namespace Escritorio.MateriaComision
{
    partial class formAgregarMateriaComision
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
            txtidEspecialidad = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtIdComision = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            mtbHora_ini = new System.Windows.Forms.MaskedTextBox();
            mtbHora_fin = new System.Windows.Forms.MaskedTextBox();
            nudCupo = new System.Windows.Forms.NumericUpDown();
            nudDS = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDS).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(31, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(325, 237);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 23);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new System.Drawing.Point(112, 76);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new System.Drawing.Size(100, 23);
            txtIdMateria.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 18;
            label2.Text = "idMateria:";
            // 
            // txtidEspecialidad
            // 
            txtidEspecialidad.Location = new System.Drawing.Point(112, 38);
            txtidEspecialidad.Name = "txtidEspecialidad";
            txtidEspecialidad.Size = new System.Drawing.Size(100, 23);
            txtidEspecialidad.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 15);
            label1.TabIndex = 16;
            label1.Text = "idEspecialidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(35, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 15);
            label3.TabIndex = 22;
            label3.Text = "idComision:";
            // 
            // txtIdComision
            // 
            txtIdComision.Location = new System.Drawing.Point(112, 118);
            txtIdComision.Name = "txtIdComision";
            txtIdComision.Size = new System.Drawing.Size(100, 23);
            txtIdComision.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(295, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 15);
            label4.TabIndex = 25;
            label4.Text = "Cupo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(235, 70);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 15);
            label5.TabIndex = 26;
            label5.Text = "Dia de la semana:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(250, 106);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(84, 15);
            label6.TabIndex = 28;
            label6.Text = "Hora de inicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(265, 140);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(69, 15);
            label7.TabIndex = 29;
            label7.Text = "Hora de fin:";
            // 
            // mtbHora_ini
            // 
            mtbHora_ini.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mtbHora_ini.Location = new System.Drawing.Point(340, 103);
            mtbHora_ini.Mask = "00:00";
            mtbHora_ini.Name = "mtbHora_ini";
            mtbHora_ini.Size = new System.Drawing.Size(35, 23);
            mtbHora_ini.TabIndex = 30;
            mtbHora_ini.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHora_fin
            // 
            mtbHora_fin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mtbHora_fin.Location = new System.Drawing.Point(340, 137);
            mtbHora_fin.Mask = "00:00";
            mtbHora_fin.Name = "mtbHora_fin";
            mtbHora_fin.Size = new System.Drawing.Size(35, 23);
            mtbHora_fin.TabIndex = 31;
            mtbHora_fin.ValidatingType = typeof(System.DateTime);
            // 
            // nudCupo
            // 
            nudCupo.Location = new System.Drawing.Point(340, 33);
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new System.Drawing.Size(35, 23);
            nudCupo.TabIndex = 32;
            // 
            // nudDS
            // 
            nudDS.Location = new System.Drawing.Point(340, 68);
            nudDS.Name = "nudDS";
            nudDS.Size = new System.Drawing.Size(35, 23);
            nudDS.TabIndex = 33;
            // 
            // formAgregarMateriaComision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(432, 281);
            Controls.Add(nudDS);
            Controls.Add(nudCupo);
            Controls.Add(mtbHora_fin);
            Controls.Add(mtbHora_ini);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtIdComision);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtIdMateria);
            Controls.Add(label2);
            Controls.Add(txtidEspecialidad);
            Controls.Add(label1);
            Name = "formAgregarMateriaComision";
            Text = "formAgregarMateriaComision";
            ((System.ComponentModel.ISupportInitialize)nudCupo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdComision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbHora_ini;
        private System.Windows.Forms.MaskedTextBox mtbHora_fin;
        private System.Windows.Forms.NumericUpDown nudCupo;
        private System.Windows.Forms.NumericUpDown nudDS;
    }
}