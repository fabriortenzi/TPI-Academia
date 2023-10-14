
namespace Escritorio.Inscripcion
{
    partial class FormMostrarCursado
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
            label20 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblAño = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            lblUsuario = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblNota = new System.Windows.Forms.Label();
            lblCurso = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(44, 15);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(32, 15);
            label20.TabIndex = 14;
            label20.Text = "Año:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(12, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(101, 39);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new System.Drawing.Point(140, 184);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(101, 39);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 9;
            label2.Text = "Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 15);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new System.Drawing.Point(152, 15);
            lblAño.Name = "lblAño";
            lblAño.Size = new System.Drawing.Size(38, 15);
            lblAño.TabIndex = 15;
            lblAño.Text = "label3";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(152, 106);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(38, 15);
            lblFecha.TabIndex = 16;
            lblFecha.Text = "label4";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new System.Drawing.Point(152, 40);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(38, 15);
            lblUsuario.TabIndex = 17;
            lblUsuario.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(35, 106);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 15);
            label6.TabIndex = 18;
            label6.Text = "Fecha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(38, 140);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(36, 15);
            label7.TabIndex = 19;
            label7.Text = "Nota:";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new System.Drawing.Point(152, 140);
            lblNota.Name = "lblNota";
            lblNota.Size = new System.Drawing.Size(38, 15);
            lblNota.TabIndex = 20;
            lblNota.Text = "label8";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new System.Drawing.Point(152, 74);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new System.Drawing.Size(38, 15);
            lblCurso.TabIndex = 21;
            lblCurso.Text = "label3";
            // 
            // FormMostrarCursado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(261, 231);
            Controls.Add(lblCurso);
            Controls.Add(lblNota);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblUsuario);
            Controls.Add(lblFecha);
            Controls.Add(lblAño);
            Controls.Add(label20);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMostrarCursado";
            Text = "FormMostrarCursado";
            Load += FormMostrarCursado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblCurso;
    }
}