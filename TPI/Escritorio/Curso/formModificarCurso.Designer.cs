
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
            lblEtiquetaComision = new System.Windows.Forms.Label();
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
            lblComision = new System.Windows.Forms.Label();
            cbxDiaSemana = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(353, 206);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(69, 15);
            label8.TabIndex = 40;
            label8.Text = "Hora de fin:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(338, 169);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(84, 15);
            label9.TabIndex = 39;
            label9.Text = "Hora de inicio:";
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraFin.Location = new System.Drawing.Point(428, 201);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new System.Drawing.Size(87, 23);
            dtpHoraFin.TabIndex = 38;
            dtpHoraFin.Value = new System.DateTime(2023, 10, 1, 21, 9, 30, 0);
            // 
            // dtpHoraIni
            // 
            dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraIni.Location = new System.Drawing.Point(430, 161);
            dtpHoraIni.Name = "dtpHoraIni";
            dtpHoraIni.Size = new System.Drawing.Size(87, 23);
            dtpHoraIni.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(343, 97);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 15);
            label7.TabIndex = 36;
            label7.Text = "Dia:";
            // 
            // lblEtiquetaComision
            // 
            lblEtiquetaComision.AutoSize = true;
            lblEtiquetaComision.Location = new System.Drawing.Point(349, 55);
            lblEtiquetaComision.Name = "lblEtiquetaComision";
            lblEtiquetaComision.Size = new System.Drawing.Size(61, 15);
            lblEtiquetaComision.TabIndex = 34;
            lblEtiquetaComision.Text = "Comision:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new System.Drawing.Point(206, 256);
            btnModificar.Margin = new System.Windows.Forms.Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(180, 34);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCupo
            // 
            txtCupo.Location = new System.Drawing.Point(140, 204);
            txtCupo.Margin = new System.Windows.Forms.Padding(2);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new System.Drawing.Size(101, 23);
            txtCupo.TabIndex = 32;
            // 
            // txtAño
            // 
            txtAño.Location = new System.Drawing.Point(140, 169);
            txtAño.Margin = new System.Windows.Forms.Padding(2);
            txtAño.Name = "txtAño";
            txtAño.PlaceholderText = "AAAA";
            txtAño.Size = new System.Drawing.Size(101, 23);
            txtAño.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(97, 210);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 15);
            label6.TabIndex = 30;
            label6.Text = "Cupo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(99, 177);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 15);
            label5.TabIndex = 29;
            label5.Text = "Ciclo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(193, 21);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(165, 15);
            label4.TabIndex = 28;
            label4.Text = "Complete los siguientes datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(86, 141);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 15);
            label3.TabIndex = 25;
            label3.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(103, 96);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 15);
            label2.TabIndex = 23;
            label2.Text = "Plan:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 55);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 22;
            label1.Text = "Especialidad:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new System.Drawing.Point(151, 143);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(44, 15);
            lblMateria.TabIndex = 45;
            lblMateria.Text = "label12";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new System.Drawing.Point(157, 97);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(44, 15);
            lblPlan.TabIndex = 44;
            lblPlan.Text = "label10";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new System.Drawing.Point(157, 55);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(38, 15);
            lblEspecialidad.TabIndex = 43;
            lblEspecialidad.Text = "label4";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(418, 55);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(44, 15);
            lblComision.TabIndex = 46;
            lblComision.Text = "label16";
            // 
            // cbxDiaSemana
            // 
            cbxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxDiaSemana.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxDiaSemana.FormattingEnabled = true;
            cbxDiaSemana.Location = new System.Drawing.Point(378, 91);
            cbxDiaSemana.Name = "cbxDiaSemana";
            cbxDiaSemana.Size = new System.Drawing.Size(148, 27);
            cbxDiaSemana.TabIndex = 47;
            cbxDiaSemana.SelectedIndexChanged += cbxDiaSemana_SelectedIndexChanged;
            // 
            // formModificarCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(601, 310);
            Controls.Add(cbxDiaSemana);
            Controls.Add(lblComision);
            Controls.Add(lblMateria);
            Controls.Add(lblPlan);
            Controls.Add(lblEspecialidad);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dtpHoraFin);
            Controls.Add(dtpHoraIni);
            Controls.Add(label7);
            Controls.Add(lblEtiquetaComision);
            Controls.Add(btnModificar);
            Controls.Add(txtCupo);
            Controls.Add(txtAño);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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