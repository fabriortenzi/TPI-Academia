namespace Escritorio.Cursado
{
    partial class formAgregarCursado
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
            label4 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            lblHorarioCurso = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbxComisiones = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            cbxCursosMateria = new System.Windows.Forms.ComboBox();
            lblAlumno = new System.Windows.Forms.Label();
            cbxAlumno = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(152, 23);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(237, 23);
            label4.TabIndex = 25;
            label4.Text = "Complete los siguientes datos";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(83, 212);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(174, 35);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirmar.Location = new System.Drawing.Point(287, 212);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(174, 35);
            btnConfirmar.TabIndex = 23;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblHorarioCurso
            // 
            lblHorarioCurso.AutoSize = true;
            lblHorarioCurso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblHorarioCurso.Location = new System.Drawing.Point(266, 162);
            lblHorarioCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHorarioCurso.Name = "lblHorarioCurso";
            lblHorarioCurso.Size = new System.Drawing.Size(94, 19);
            lblHorarioCurso.TabIndex = 22;
            lblHorarioCurso.Text = "HorarioCurso";
            lblHorarioCurso.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(196, 162);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 19);
            label3.TabIndex = 21;
            label3.Text = "Horario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(178, 132);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 19);
            label2.TabIndex = 20;
            label2.Text = "Comision";
            // 
            // cbxComisiones
            // 
            cbxComisiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComisiones.Enabled = false;
            cbxComisiones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxComisiones.FormattingEnabled = true;
            cbxComisiones.Location = new System.Drawing.Point(266, 129);
            cbxComisiones.Margin = new System.Windows.Forms.Padding(2);
            cbxComisiones.Name = "cbxComisiones";
            cbxComisiones.Size = new System.Drawing.Size(140, 27);
            cbxComisiones.TabIndex = 19;
            cbxComisiones.SelectedIndexChanged += cbxComisiones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(178, 96);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 19);
            label1.TabIndex = 18;
            label1.Text = "Materia:";
            // 
            // cbxCursosMateria
            // 
            cbxCursosMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCursosMateria.Enabled = false;
            cbxCursosMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxCursosMateria.FormattingEnabled = true;
            cbxCursosMateria.Location = new System.Drawing.Point(266, 93);
            cbxCursosMateria.Margin = new System.Windows.Forms.Padding(2);
            cbxCursosMateria.Name = "cbxCursosMateria";
            cbxCursosMateria.Size = new System.Drawing.Size(211, 27);
            cbxCursosMateria.TabIndex = 17;
            cbxCursosMateria.SelectedIndexChanged += cbxCursosMateria_SelectedIndexChanged;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAlumno.Location = new System.Drawing.Point(180, 59);
            lblAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new System.Drawing.Size(62, 19);
            lblAlumno.TabIndex = 27;
            lblAlumno.Text = "Alumno:";
            // 
            // cbxAlumno
            // 
            cbxAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxAlumno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxAlumno.FormattingEnabled = true;
            cbxAlumno.Location = new System.Drawing.Point(267, 56);
            cbxAlumno.Margin = new System.Windows.Forms.Padding(2);
            cbxAlumno.Name = "cbxAlumno";
            cbxAlumno.Size = new System.Drawing.Size(211, 27);
            cbxAlumno.TabIndex = 26;
            cbxAlumno.SelectedIndexChanged += cbxAlumno_SelectedIndexChanged;
            // 
            // formAgregarCursado
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(560, 270);
            Controls.Add(lblAlumno);
            Controls.Add(cbxAlumno);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblHorarioCurso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxComisiones);
            Controls.Add(label1);
            Controls.Add(cbxCursosMateria);
            Name = "formAgregarCursado";
            Text = "formAgregarCursado";
            Load += formAgregarCursado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblHorarioCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxComisiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCursosMateria;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.ComboBox cbxAlumno;
    }
}