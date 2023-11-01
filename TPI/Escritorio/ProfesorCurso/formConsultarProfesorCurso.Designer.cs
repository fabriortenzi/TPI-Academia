
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
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(148, 432);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(222, 53);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConsultar.Location = new System.Drawing.Point(428, 432);
            btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(222, 53);
            btnConsultar.TabIndex = 24;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cbxComision
            // 
            cbxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComision.Enabled = false;
            cbxComision.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new System.Drawing.Point(197, 330);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new System.Drawing.Size(210, 37);
            cbxComision.TabIndex = 63;
            cbxComision.SelectedIndexChanged += cbxComision_SelectedIndexChanged;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblComision.Location = new System.Drawing.Point(79, 333);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(111, 29);
            lblComision.TabIndex = 62;
            lblComision.Text = "Comision:";
            // 
            // cbxMaterias
            // 
            cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMaterias.Enabled = false;
            cbxMaterias.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxMaterias.FormattingEnabled = true;
            cbxMaterias.Location = new System.Drawing.Point(197, 257);
            cbxMaterias.Name = "cbxMaterias";
            cbxMaterias.Size = new System.Drawing.Size(500, 37);
            cbxMaterias.TabIndex = 61;
            cbxMaterias.SelectedIndexChanged += cbxMaterias_SelectedIndexChanged;
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(197, 187);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(161, 37);
            cbxPlanes.TabIndex = 60;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(92, 260);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 29);
            label3.TabIndex = 59;
            label3.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(129, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 29);
            label2.TabIndex = 58;
            label2.Text = "Plan:";
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(197, 123);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(500, 37);
            cbxEspecialidades.TabIndex = 57;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(47, 126);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(143, 29);
            label5.TabIndex = 56;
            label5.Text = "Especialidad:";
            // 
            // cbxLegajo
            // 
            cbxLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxLegajo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxLegajo.FormattingEnabled = true;
            cbxLegajo.Location = new System.Drawing.Point(197, 51);
            cbxLegajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbxLegajo.Name = "cbxLegajo";
            cbxLegajo.Size = new System.Drawing.Size(500, 37);
            cbxLegajo.TabIndex = 55;
            cbxLegajo.SelectedIndexChanged += cbxLegajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(89, 54);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 29);
            label1.TabIndex = 54;
            label1.Text = "Profesor:";
            // 
            // formConsultarProfesorCurso
            // 
            AcceptButton = btnConsultar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(798, 516);
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
            Text = "Consultar Profesor-Curso";
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