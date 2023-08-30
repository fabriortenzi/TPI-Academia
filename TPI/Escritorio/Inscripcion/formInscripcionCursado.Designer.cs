namespace Escritorio.Inscripcion
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
            btnCancelar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            lblHorarioCurso = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbxComisiones = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            cbxCursosMateria = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(198, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(193, 64);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(435, 294);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(194, 64);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // lblHorarioCurso
            // 
            lblHorarioCurso.AutoSize = true;
            lblHorarioCurso.Location = new System.Drawing.Point(357, 207);
            lblHorarioCurso.Name = "lblHorarioCurso";
            lblHorarioCurso.Size = new System.Drawing.Size(118, 25);
            lblHorarioCurso.TabIndex = 13;
            lblHorarioCurso.Text = "HorarioCurso";
            lblHorarioCurso.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(275, 207);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 25);
            label3.TabIndex = 12;
            label3.Text = "Horario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(143, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(208, 25);
            label2.TabIndex = 11;
            label2.Text = "Seleccione una Comision";
            // 
            // cbxComisiones
            // 
            cbxComisiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComisiones.FormattingEnabled = true;
            cbxComisiones.Location = new System.Drawing.Point(357, 152);
            cbxComisiones.Name = "cbxComisiones";
            cbxComisiones.Size = new System.Drawing.Size(199, 33);
            cbxComisiones.TabIndex = 10;
            cbxComisiones.SelectedIndexChanged += cbxComisiones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(159, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 25);
            label1.TabIndex = 9;
            label1.Text = "Seleccione una Materia";
            // 
            // cbxCursosMateria
            // 
            cbxCursosMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCursosMateria.FormattingEnabled = true;
            cbxCursosMateria.Location = new System.Drawing.Point(357, 92);
            cbxCursosMateria.Name = "cbxCursosMateria";
            cbxCursosMateria.Size = new System.Drawing.Size(300, 33);
            cbxCursosMateria.TabIndex = 8;
            cbxCursosMateria.SelectedIndexChanged += cbxCursosMateria_SelectedIndexChanged;
            // 
            // formInscripcionCursado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblHorarioCurso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxComisiones);
            Controls.Add(label1);
            Controls.Add(cbxCursosMateria);
            Name = "formInscripcionCursado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Inscripcion a Cursado";
            Load += formInscripcionCursado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblHorarioCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxComisiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCursosMateria;
    }
}