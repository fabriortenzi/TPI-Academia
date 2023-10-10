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
            txtDia = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(72, 56);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Especialidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(114, 97);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Plan:";
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(151, 53);
            cbxEspecialidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(148, 23);
            cbxEspecialidades.TabIndex = 2;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(97, 142);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Materia:";
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(151, 97);
            cbxPlanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(148, 23);
            cbxPlanes.TabIndex = 4;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // cbxMaterias
            // 
            cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMaterias.Enabled = false;
            cbxMaterias.FormattingEnabled = true;
            cbxMaterias.Location = new System.Drawing.Point(151, 134);
            cbxMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbxMaterias.Name = "cbxMaterias";
            cbxMaterias.Size = new System.Drawing.Size(148, 23);
            cbxMaterias.TabIndex = 5;
            cbxMaterias.SelectedIndexChanged += cbxMaterias_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(204, 22);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(165, 15);
            label4.TabIndex = 6;
            label4.Text = "Complete los siguientes datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(110, 178);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 15);
            label5.TabIndex = 7;
            label5.Text = "Ciclo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(108, 211);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Cupo:";
            // 
            // txtAño
            // 
            txtAño.Location = new System.Drawing.Point(151, 170);
            txtAño.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtAño.Name = "txtAño";
            txtAño.PlaceholderText = "AAAA";
            txtAño.Size = new System.Drawing.Size(101, 23);
            txtAño.TabIndex = 9;
            // 
            // txtCupo
            // 
            txtCupo.Location = new System.Drawing.Point(151, 203);
            txtCupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new System.Drawing.Size(101, 23);
            txtCupo.TabIndex = 10;
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(217, 257);
            btnCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(180, 34);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += button1_Click;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(336, 59);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(61, 15);
            lblComision.TabIndex = 12;
            lblComision.Text = "Comision:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(370, 94);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "Dia:";
            // 
            // dtpHoraIni
            // 
            dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraIni.Location = new System.Drawing.Point(405, 129);
            dtpHoraIni.Name = "dtpHoraIni";
            dtpHoraIni.ShowUpDown = true;
            dtpHoraIni.Size = new System.Drawing.Size(111, 23);
            dtpHoraIni.TabIndex = 16;
            dtpHoraIni.Value = new System.DateTime(2023, 10, 5, 0, 0, 0, 0);
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraFin.Location = new System.Drawing.Point(403, 171);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new System.Drawing.Size(113, 23);
            dtpHoraFin.TabIndex = 17;
            dtpHoraFin.Value = new System.DateTime(2023, 10, 1, 12, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(313, 137);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(84, 15);
            label9.TabIndex = 19;
            label9.Text = "Hora de inicio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(328, 176);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(69, 15);
            label8.TabIndex = 20;
            label8.Text = "Hora de fin:";
            // 
            // cbxComision
            // 
            cbxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComision.Enabled = false;
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new System.Drawing.Point(402, 53);
            cbxComision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new System.Drawing.Size(148, 23);
            cbxComision.TabIndex = 21;
            cbxComision.SelectedIndexChanged += cbxComision_SelectedIndexChanged;
            cbxComision.SelectionChangeCommitted += cbxComision_SelectionChangeCommitted;
            // 
            // txtDia
            // 
            txtDia.Location = new System.Drawing.Point(403, 90);
            txtDia.Name = "txtDia";
            txtDia.Size = new System.Drawing.Size(121, 23);
            txtDia.TabIndex = 14;
            // 
            // formCrearCurso
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(601, 310);
            Controls.Add(cbxComision);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dtpHoraFin);
            Controls.Add(dtpHoraIni);
            Controls.Add(label7);
            Controls.Add(txtDia);
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
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtDia;
    }
}