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
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            mtbHora_ini = new System.Windows.Forms.MaskedTextBox();
            mtbHora_fin = new System.Windows.Forms.MaskedTextBox();
            nudCupo = new System.Windows.Forms.NumericUpDown();
            nudDS = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbxMateria = new System.Windows.Forms.ComboBox();
            cbxComision = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDS).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(44, 395);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(107, 38);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(464, 395);
            btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(107, 38);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(421, 58);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 25);
            label4.TabIndex = 25;
            label4.Text = "Cupo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(336, 117);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(151, 25);
            label5.TabIndex = 26;
            label5.Text = "Dia de la semana:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(357, 177);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(126, 25);
            label6.TabIndex = 28;
            label6.Text = "Hora de inicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(379, 233);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(105, 25);
            label7.TabIndex = 29;
            label7.Text = "Hora de fin:";
            // 
            // mtbHora_ini
            // 
            mtbHora_ini.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mtbHora_ini.Location = new System.Drawing.Point(486, 172);
            mtbHora_ini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            mtbHora_ini.Mask = "00:00";
            mtbHora_ini.Name = "mtbHora_ini";
            mtbHora_ini.Size = new System.Drawing.Size(48, 31);
            mtbHora_ini.TabIndex = 30;
            mtbHora_ini.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHora_fin
            // 
            mtbHora_fin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mtbHora_fin.Location = new System.Drawing.Point(486, 228);
            mtbHora_fin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            mtbHora_fin.Mask = "00:00";
            mtbHora_fin.Name = "mtbHora_fin";
            mtbHora_fin.Size = new System.Drawing.Size(48, 31);
            mtbHora_fin.TabIndex = 31;
            mtbHora_fin.ValidatingType = typeof(System.DateTime);
            // 
            // nudCupo
            // 
            nudCupo.Location = new System.Drawing.Point(486, 55);
            nudCupo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new System.Drawing.Size(50, 31);
            nudCupo.TabIndex = 32;
            // 
            // nudDS
            // 
            nudDS.Location = new System.Drawing.Point(486, 113);
            nudDS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nudDS.Name = "nudDS";
            nudDS.Size = new System.Drawing.Size(50, 31);
            nudDS.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 102);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 25);
            label1.TabIndex = 34;
            label1.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(30, 185);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 25);
            label2.TabIndex = 35;
            label2.Text = "Comision:";
            // 
            // cbxMateria
            // 
            cbxMateria.FormattingEnabled = true;
            cbxMateria.Location = new System.Drawing.Point(121, 97);
            cbxMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbxMateria.Name = "cbxMateria";
            cbxMateria.Size = new System.Drawing.Size(171, 33);
            cbxMateria.TabIndex = 36;
            // 
            // cbxComision
            // 
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new System.Drawing.Point(121, 177);
            cbxComision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new System.Drawing.Size(171, 33);
            cbxComision.TabIndex = 37;
            // 
            // formAgregarMateriaComision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(617, 468);
            Controls.Add(cbxComision);
            Controls.Add(cbxMateria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudDS);
            Controls.Add(nudCupo);
            Controls.Add(mtbHora_fin);
            Controls.Add(mtbHora_ini);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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