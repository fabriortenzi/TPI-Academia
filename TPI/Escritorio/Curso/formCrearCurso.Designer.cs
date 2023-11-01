namespace Escritorio
{
    partial class formCrearCurso
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
            label2 = new System.Windows.Forms.Label();
            cbxEspecialidades = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cbxPlanes = new System.Windows.Forms.ComboBox();
            cbxMaterias = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtAño = new System.Windows.Forms.TextBox();
            txtCupo = new System.Windows.Forms.TextBox();
            btnCrear = new System.Windows.Forms.Button();
            lblComision = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            dtpHoraIni = new System.Windows.Forms.DateTimePicker();
            dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            cbxComision = new System.Windows.Forms.ComboBox();
            cbxDiaSemana = new System.Windows.Forms.ComboBox();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(67, 139);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 29);
            label1.TabIndex = 0;
            label1.Text = "Especialidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(148, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 29);
            label2.TabIndex = 1;
            label2.Text = "Plan:";
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(216, 136);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(500, 37);
            cbxEspecialidades.TabIndex = 2;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(112, 263);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 29);
            label3.TabIndex = 3;
            label3.Text = "Materia:";
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(216, 197);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(210, 37);
            cbxPlanes.TabIndex = 4;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // cbxMaterias
            // 
            cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMaterias.Enabled = false;
            cbxMaterias.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxMaterias.FormattingEnabled = true;
            cbxMaterias.Location = new System.Drawing.Point(216, 258);
            cbxMaterias.Name = "cbxMaterias";
            cbxMaterias.Size = new System.Drawing.Size(500, 37);
            cbxMaterias.TabIndex = 5;
            cbxMaterias.SelectedIndexChanged += cbxMaterias_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(466, 30);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(352, 35);
            label4.TabIndex = 6;
            label4.Text = "Complete los siguientes datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(143, 321);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 29);
            label5.TabIndex = 7;
            label5.Text = "Ciclo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(139, 376);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 29);
            label6.TabIndex = 8;
            label6.Text = "Cupo:";
            // 
            // txtAño
            // 
            txtAño.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAño.Location = new System.Drawing.Point(216, 318);
            txtAño.Name = "txtAño";
            txtAño.PlaceholderText = "AAAA";
            txtAño.Size = new System.Drawing.Size(143, 37);
            txtAño.TabIndex = 9;
            // 
            // txtCupo
            // 
            txtCupo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCupo.Location = new System.Drawing.Point(216, 373);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new System.Drawing.Size(143, 37);
            txtCupo.TabIndex = 10;
            // 
            // btnCrear
            // 
            btnCrear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCrear.Location = new System.Drawing.Point(803, 486);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(257, 57);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += button1_Click;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblComision.Location = new System.Drawing.Point(848, 133);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(111, 29);
            lblComision.TabIndex = 12;
            lblComision.Text = "Comision:";
            lblComision.Click += lblComision_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(905, 200);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 29);
            label7.TabIndex = 15;
            label7.Text = "Dia:";
            label7.Click += label7_Click;
            // 
            // dtpHoraIni
            // 
            dtpHoraIni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraIni.Location = new System.Drawing.Point(964, 255);
            dtpHoraIni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpHoraIni.Name = "dtpHoraIni";
            dtpHoraIni.ShowUpDown = true;
            dtpHoraIni.Size = new System.Drawing.Size(210, 37);
            dtpHoraIni.TabIndex = 16;
            dtpHoraIni.Value = new System.DateTime(2023, 10, 5, 0, 0, 0, 0);
            dtpHoraIni.ValueChanged += dtpHoraIni_ValueChanged;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraFin.Location = new System.Drawing.Point(964, 315);
            dtpHoraFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new System.Drawing.Size(210, 37);
            dtpHoraFin.TabIndex = 17;
            dtpHoraFin.Value = new System.DateTime(2023, 10, 1, 12, 0, 0, 0);
            dtpHoraFin.ValueChanged += dtpHoraFin_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(803, 258);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(156, 29);
            label9.TabIndex = 19;
            label9.Text = "Hora de inicio:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(828, 321);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(128, 29);
            label8.TabIndex = 20;
            label8.Text = "Hora de fin:";
            label8.Click += label8_Click;
            // 
            // cbxComision
            // 
            cbxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComision.Enabled = false;
            cbxComision.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new System.Drawing.Point(964, 131);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new System.Drawing.Size(210, 37);
            cbxComision.TabIndex = 21;
            cbxComision.SelectedIndexChanged += cbxComision_SelectedIndexChanged;
            cbxComision.SelectionChangeCommitted += cbxComision_SelectionChangeCommitted;
            // 
            // cbxDiaSemana
            // 
            cbxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxDiaSemana.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxDiaSemana.FormattingEnabled = true;
            cbxDiaSemana.Location = new System.Drawing.Point(964, 197);
            cbxDiaSemana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbxDiaSemana.Name = "cbxDiaSemana";
            cbxDiaSemana.Size = new System.Drawing.Size(210, 37);
            cbxDiaSemana.TabIndex = 22;
            cbxDiaSemana.SelectedIndexChanged += cbxDiaSemana_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(216, 486);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(257, 57);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formCrearCurso
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(1261, 583);
            Controls.Add(btnCancelar);
            Controls.Add(cbxDiaSemana);
            Controls.Add(cbxComision);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dtpHoraFin);
            Controls.Add(dtpHoraIni);
            Controls.Add(label7);
            Controls.Add(lblComision);
            Controls.Add(btnCrear);
            Controls.Add(txtCupo);
            Controls.Add(txtAño);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbxMaterias);
            Controls.Add(cbxPlanes);
            Controls.Add(label3);
            Controls.Add(cbxEspecialidades);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formCrearCurso";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Crear Curso";
            Load += formCrearCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEspecialidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.ComboBox cbxMaterias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHoraIni;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxComision;
        private System.Windows.Forms.ComboBox cbxDiaSemana;
        private System.Windows.Forms.Button btnCancelar;
    }
}