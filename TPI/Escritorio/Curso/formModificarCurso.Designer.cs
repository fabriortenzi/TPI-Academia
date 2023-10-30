
namespace Escritorio.Curso
{
    partial class formModificarCurso
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
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            dtpHoraIni = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            lblComision = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            txtCupo = new System.Windows.Forms.TextBox();
            txtAño = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblMateria = new System.Windows.Forms.Label();
            lblPlan = new System.Windows.Forms.Label();
            lblEspecialidad = new System.Windows.Forms.Label();
            cbxDiaSemana = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(453, 292);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(105, 25);
            label8.TabIndex = 40;
            label8.Text = "Hora de fin:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(431, 227);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(126, 25);
            label9.TabIndex = 39;
            label9.Text = "Hora de inicio:";
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraFin.Location = new System.Drawing.Point(560, 283);
            dtpHoraFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new System.Drawing.Size(196, 31);
            dtpHoraFin.TabIndex = 38;
            dtpHoraFin.Value = new System.DateTime(2023, 10, 1, 21, 9, 30, 0);
            // 
            // dtpHoraIni
            // 
            dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraIni.Location = new System.Drawing.Point(563, 213);
            dtpHoraIni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpHoraIni.Name = "dtpHoraIni";
            dtpHoraIni.Size = new System.Drawing.Size(193, 31);
            dtpHoraIni.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(513, 155);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 25);
            label7.TabIndex = 36;
            label7.Text = "Dia:";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(464, 97);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(91, 25);
            lblComision.TabIndex = 34;
            lblComision.Text = "Comision:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new System.Drawing.Point(294, 427);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(257, 57);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCupo
            // 
            txtCupo.Location = new System.Drawing.Point(200, 337);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new System.Drawing.Size(143, 31);
            txtCupo.TabIndex = 32;
            // 
            // txtAño
            // 
            txtAño.Location = new System.Drawing.Point(200, 282);
            txtAño.Name = "txtAño";
            txtAño.PlaceholderText = "AAAA";
            txtAño.Size = new System.Drawing.Size(143, 31);
            txtAño.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(139, 350);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 25);
            label6.TabIndex = 30;
            label6.Text = "Cupo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(141, 295);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 25);
            label5.TabIndex = 29;
            label5.Text = "Ciclo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(276, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(251, 25);
            label4.TabIndex = 28;
            label4.Text = "Complete los siguientes datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(123, 235);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 25);
            label3.TabIndex = 25;
            label3.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(147, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 25);
            label2.TabIndex = 23;
            label2.Text = "Plan:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(87, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 25);
            label1.TabIndex = 22;
            label1.Text = "Especialidad:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new System.Drawing.Point(216, 238);
            lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(69, 25);
            lblMateria.TabIndex = 45;
            lblMateria.Text = "label12";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new System.Drawing.Point(224, 162);
            lblPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(69, 25);
            lblPlan.TabIndex = 44;
            lblPlan.Text = "label10";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new System.Drawing.Point(224, 92);
            lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(59, 25);
            lblEspecialidad.TabIndex = 43;
            lblEspecialidad.Text = "label4";
            // 
            // cbxDiaSemana
            // 
            cbxDiaSemana.FormattingEnabled = true;
            cbxDiaSemana.Location = new System.Drawing.Point(574, 146);
            cbxDiaSemana.Name = "cbxDiaSemana";
            cbxDiaSemana.Size = new System.Drawing.Size(182, 33);
            cbxDiaSemana.TabIndex = 46;
            // 
            // formModificarCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 517);
            Controls.Add(cbxDiaSemana);
            Controls.Add(lblMateria);
            Controls.Add(lblPlan);
            Controls.Add(lblEspecialidad);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dtpHoraFin);
            Controls.Add(dtpHoraIni);
            Controls.Add(label7);
            Controls.Add(lblComision);
            Controls.Add(btnModificar);
            Controls.Add(txtCupo);
            Controls.Add(txtAño);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "formModificarCurso";
            Text = "formModificarCurso";
            Load += formModificarCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraIni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEtiquetaComision;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cbxDiaSemana;
    }
}