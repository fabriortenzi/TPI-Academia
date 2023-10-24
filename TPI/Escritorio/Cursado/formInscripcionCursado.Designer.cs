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
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(130, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(248, 59);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirmar.Location = new System.Drawing.Point(422, 346);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(249, 59);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblHorarioCurso
            // 
            lblHorarioCurso.AutoSize = true;
            lblHorarioCurso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblHorarioCurso.Location = new System.Drawing.Point(393, 248);
            lblHorarioCurso.Name = "lblHorarioCurso";
            lblHorarioCurso.Size = new System.Drawing.Size(144, 29);
            lblHorarioCurso.TabIndex = 13;
            lblHorarioCurso.Text = "HorarioCurso";
            lblHorarioCurso.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(293, 248);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 29);
            label3.TabIndex = 12;
            label3.Text = "Horario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(129, 196);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(258, 29);
            label2.TabIndex = 11;
            label2.Text = "Seleccione una Comision";
            // 
            // cbxComisiones
            // 
            cbxComisiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComisiones.Enabled = false;
            cbxComisiones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxComisiones.FormattingEnabled = true;
            cbxComisiones.Location = new System.Drawing.Point(393, 193);
            cbxComisiones.Name = "cbxComisiones";
            cbxComisiones.Size = new System.Drawing.Size(199, 37);
            cbxComisiones.TabIndex = 10;
            cbxComisiones.SelectedIndexChanged += cbxComisiones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(142, 136);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 29);
            label1.TabIndex = 9;
            label1.Text = "Seleccione una Materia";
            // 
            // cbxCursosMateria
            // 
            cbxCursosMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCursosMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxCursosMateria.FormattingEnabled = true;
            cbxCursosMateria.Location = new System.Drawing.Point(393, 133);
            cbxCursosMateria.Name = "cbxCursosMateria";
            cbxCursosMateria.Size = new System.Drawing.Size(300, 37);
            cbxCursosMateria.TabIndex = 8;
            cbxCursosMateria.SelectedIndexChanged += cbxCursosMateria_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(228, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(352, 35);
            label4.TabIndex = 16;
            label4.Text = "Complete los siguientes datos";
            // 
            // formInscripcionCursado
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label4);
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
        private System.Windows.Forms.Label label4;
    }
}