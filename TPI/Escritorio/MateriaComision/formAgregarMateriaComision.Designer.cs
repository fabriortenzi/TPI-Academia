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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbHora_ini = new System.Windows.Forms.MaskedTextBox();
            this.mtbHora_fin = new System.Windows.Forms.MaskedTextBox();
            this.nudCupo = new System.Windows.Forms.NumericUpDown();
            this.nudDS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.cbxComision = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(31, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(325, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Dia de la semana:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hora de inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Hora de fin:";
            // 
            // mtbHora_ini
            // 
            this.mtbHora_ini.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbHora_ini.Location = new System.Drawing.Point(340, 103);
            this.mtbHora_ini.Mask = "00:00";
            this.mtbHora_ini.Name = "mtbHora_ini";
            this.mtbHora_ini.Size = new System.Drawing.Size(35, 23);
            this.mtbHora_ini.TabIndex = 30;
            this.mtbHora_ini.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHora_fin
            // 
            this.mtbHora_fin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbHora_fin.Location = new System.Drawing.Point(340, 137);
            this.mtbHora_fin.Mask = "00:00";
            this.mtbHora_fin.Name = "mtbHora_fin";
            this.mtbHora_fin.Size = new System.Drawing.Size(35, 23);
            this.mtbHora_fin.TabIndex = 31;
            this.mtbHora_fin.ValidatingType = typeof(System.DateTime);
            // 
            // nudCupo
            // 
            this.nudCupo.Location = new System.Drawing.Point(340, 33);
            this.nudCupo.Name = "nudCupo";
            this.nudCupo.Size = new System.Drawing.Size(35, 23);
            this.nudCupo.TabIndex = 32;
            // 
            // nudDS
            // 
            this.nudDS.Location = new System.Drawing.Point(340, 68);
            this.nudDS.Name = "nudDS";
            this.nudDS.Size = new System.Drawing.Size(35, 23);
            this.nudDS.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Comision:";
            // 
            // cbxMateria
            // 
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(85, 58);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(121, 23);
            this.cbxMateria.TabIndex = 36;
            // 
            // cbxComision
            // 
            this.cbxComision.FormattingEnabled = true;
            this.cbxComision.Location = new System.Drawing.Point(85, 106);
            this.cbxComision.Name = "cbxComision";
            this.cbxComision.Size = new System.Drawing.Size(121, 23);
            this.cbxComision.TabIndex = 37;
            // 
            // formAgregarMateriaComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 281);
            this.Controls.Add(this.cbxComision);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDS);
            this.Controls.Add(this.nudCupo);
            this.Controls.Add(this.mtbHora_fin);
            this.Controls.Add(this.mtbHora_ini);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "formAgregarMateriaComision";
            this.Text = "formAgregarMateriaComision";
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbHora_ini;
        private System.Windows.Forms.MaskedTextBox mtbHora_fin;
        private System.Windows.Forms.NumericUpDown nudCupo;
        private System.Windows.Forms.NumericUpDown nudDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.ComboBox cbxComision;
    }
}