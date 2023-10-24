
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
            cbxComision = new System.Windows.Forms.ComboBox();
            lblComision = new System.Windows.Forms.Label();
            cbxMaterias = new System.Windows.Forms.ComboBox();
            cbxPlanes = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbxEspecialidades = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            cbxLegajo = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(44, 383);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(107, 38);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new System.Drawing.Point(223, 383);
            btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(107, 38);
            btnConsultar.TabIndex = 24;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cbxComision
            // 
            cbxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComision.Enabled = false;
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new System.Drawing.Point(119, 313);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new System.Drawing.Size(210, 33);
            cbxComision.TabIndex = 63;
            cbxComision.SelectedIndexChanged += cbxComision_SelectedIndexChanged;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(24, 323);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(91, 25);
            lblComision.TabIndex = 62;
            lblComision.Text = "Comision:";
            // 
            // cbxMaterias
            // 
            cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMaterias.Enabled = false;
            cbxMaterias.FormattingEnabled = true;
            cbxMaterias.Location = new System.Drawing.Point(119, 237);
            cbxMaterias.Name = "cbxMaterias";
            cbxMaterias.Size = new System.Drawing.Size(210, 33);
            cbxMaterias.TabIndex = 61;
            cbxMaterias.SelectedIndexChanged += cbxMaterias_SelectedIndexChanged;
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(119, 175);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(210, 33);
            cbxPlanes.TabIndex = 60;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(41, 250);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 25);
            label3.TabIndex = 59;
            label3.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(66, 175);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 25);
            label2.TabIndex = 58;
            label2.Text = "Plan:";
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(119, 103);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(210, 33);
            cbxEspecialidades.TabIndex = 57;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 108);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 25);
            label5.TabIndex = 56;
            label5.Text = "Especialidad:";
            // 
            // cbxLegajo
            // 
            cbxLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxLegajo.FormattingEnabled = true;
            cbxLegajo.Location = new System.Drawing.Point(119, 22);
            cbxLegajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbxLegajo.Name = "cbxLegajo";
            cbxLegajo.Size = new System.Drawing.Size(210, 33);
            cbxLegajo.TabIndex = 55;
            cbxLegajo.SelectedIndexChanged += cbxLegajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 27);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 25);
            label1.TabIndex = 54;
            label1.Text = "Profesor:";
            // 
            // formConsultarProfesorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(374, 472);
            Controls.Add(cbxComision);
            Controls.Add(lblComision);
            Controls.Add(cbxMaterias);
            Controls.Add(cbxPlanes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxEspecialidades);
            Controls.Add(label5);
            Controls.Add(cbxLegajo);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConsultar);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "formConsultarProfesorCurso";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "formConsultarProfesorCurso";
            Load += formConsultarProfesorCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbxComision;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cbxMaterias;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEspecialidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxLegajo;
        private System.Windows.Forms.Label label1;
    }
}