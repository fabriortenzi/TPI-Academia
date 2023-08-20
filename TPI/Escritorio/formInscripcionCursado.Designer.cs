namespace Escritorio
{
    partial class formInscripcionCursado
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
            cbxCursosMateria = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            lblHorarioCurso = new System.Windows.Forms.Label();
            btnConfirmar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cbxCursosMateria
            // 
            cbxCursosMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCursosMateria.FormattingEnabled = true;
            cbxCursosMateria.Location = new System.Drawing.Point(322, 61);
            cbxCursosMateria.Name = "cbxCursosMateria";
            cbxCursosMateria.Size = new System.Drawing.Size(300, 33);
            cbxCursosMateria.TabIndex = 0;
            cbxCursosMateria.SelectedIndexChanged += cbxCursosMateria_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(124, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 25);
            label1.TabIndex = 1;
            label1.Text = "Seleccione una Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(108, 124);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(208, 25);
            label2.TabIndex = 3;
            label2.Text = "Seleccione una Comision";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(322, 121);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(199, 33);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(240, 176);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 25);
            label3.TabIndex = 4;
            label3.Text = "Horario:";
            // 
            // lblHorarioCurso
            // 
            lblHorarioCurso.AutoSize = true;
            lblHorarioCurso.Location = new System.Drawing.Point(322, 176);
            lblHorarioCurso.Name = "lblHorarioCurso";
            lblHorarioCurso.Size = new System.Drawing.Size(118, 25);
            lblHorarioCurso.TabIndex = 5;
            lblHorarioCurso.Text = "HorarioCurso";
            lblHorarioCurso.Visible = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(400, 263);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(194, 64);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(163, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(193, 64);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // formInscripcionCursado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(748, 374);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblHorarioCurso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(cbxCursosMateria);
            Name = "formInscripcionCursado";
            Text = "Inscripcion a Cursado";
            Load += formInscripcionCursado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCursosMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHorarioCurso;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}