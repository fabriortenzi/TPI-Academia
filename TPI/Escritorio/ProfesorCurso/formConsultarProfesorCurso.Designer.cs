
namespace Escritorio.ProfesorCurso
{
    partial class formConsultarProfesorCurso
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
            btnConsultar = new System.Windows.Forms.Button();
            cbxLegajo = new System.Windows.Forms.ComboBox();
            cbxCurso = new System.Windows.Forms.ComboBox();
            lblMateria = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(22, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new System.Drawing.Point(147, 230);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(75, 23);
            btnConsultar.TabIndex = 24;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cbxLegajo
            // 
            cbxLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxLegajo.FormattingEnabled = true;
            cbxLegajo.Location = new System.Drawing.Point(84, 42);
            cbxLegajo.Name = "cbxLegajo";
            cbxLegajo.Size = new System.Drawing.Size(100, 23);
            cbxLegajo.TabIndex = 37;
            cbxLegajo.SelectedIndexChanged += cbxLegajo_SelectedIndexChanged;
            // 
            // cbxCurso
            // 
            cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCurso.Enabled = false;
            cbxCurso.FormattingEnabled = true;
            cbxCurso.Location = new System.Drawing.Point(84, 91);
            cbxCurso.Name = "cbxCurso";
            cbxCurso.Size = new System.Drawing.Size(100, 23);
            cbxCurso.TabIndex = 36;
            cbxCurso.SelectedIndexChanged += cbxCurso_SelectedIndexChanged;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new System.Drawing.Point(26, 94);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(41, 15);
            lblMateria.TabIndex = 35;
            lblMateria.Text = "Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 34;
            label1.Text = "Legajo:";
            // 
            // formConsultarProfesorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(245, 281);
            Controls.Add(cbxLegajo);
            Controls.Add(cbxCurso);
            Controls.Add(lblMateria);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConsultar);
            Name = "formConsultarProfesorCurso";
            Text = "formConsultarProfesorCurso";
            Load += formConsultarProfesorCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbxLegajo;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label label1;
    }
}