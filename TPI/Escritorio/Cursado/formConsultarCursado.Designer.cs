
namespace Escritorio.Inscripcion
{
    partial class formConsultarCursado
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
            cbxUsuario = new System.Windows.Forms.ComboBox();
            cbxCurso = new System.Windows.Forms.ComboBox();
            btnConsultar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            lblAño = new System.Windows.Forms.Label();
            txtCiclo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Curso:";
            // 
            // cbxUsuario
            // 
            cbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxUsuario.FormattingEnabled = true;
            cbxUsuario.Location = new System.Drawing.Point(100, 63);
            cbxUsuario.Name = "cbxUsuario";
            cbxUsuario.Size = new System.Drawing.Size(175, 23);
            cbxUsuario.TabIndex = 2;
            cbxUsuario.SelectedIndexChanged += cbxUsuario_SelectedIndexChanged;
            cbxUsuario.SelectionChangeCommitted += cbxUsuario_SelectionChangeCommitted;
            // 
            // cbxCurso
            // 
            cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCurso.Enabled = false;
            cbxCurso.FormattingEnabled = true;
            cbxCurso.Location = new System.Drawing.Point(100, 104);
            cbxCurso.Name = "cbxCurso";
            cbxCurso.Size = new System.Drawing.Size(175, 23);
            cbxCurso.TabIndex = 3;
            cbxCurso.SelectedIndexChanged += cbxCurso_SelectedIndexChanged;
            cbxCurso.TextChanged += cbxCurso_TextChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new System.Drawing.Point(241, 155);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(101, 39);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(12, 155);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(101, 39);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new System.Drawing.Point(58, 22);
            lblAño.Name = "lblAño";
            lblAño.Size = new System.Drawing.Size(32, 15);
            lblAño.TabIndex = 6;
            lblAño.Text = "Año:";
            // 
            // txtCiclo
            // 
            txtCiclo.Location = new System.Drawing.Point(100, 19);
            txtCiclo.Name = "txtCiclo";
            txtCiclo.Size = new System.Drawing.Size(175, 23);
            txtCiclo.TabIndex = 7;
            // 
            // formConsultarCursado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(354, 213);
            Controls.Add(txtCiclo);
            Controls.Add(lblAño);
            Controls.Add(btnCancelar);
            Controls.Add(btnConsultar);
            Controls.Add(cbxCurso);
            Controls.Add(cbxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formConsultarCursado";
            Text = "formConsultarCursado";
            Load += formConsultarCursado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtCiclo;
    }
}