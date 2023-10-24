namespace Escritorio.ProfesorCurso
{
    partial class formAgregarProfesorCurso
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
            btnAgregar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtCargo = new System.Windows.Forms.TextBox();
            cbxLegajo = new System.Windows.Forms.ComboBox();
            cbxComision = new System.Windows.Forms.ComboBox();
            lblComision = new System.Windows.Forms.Label();
            cbxMaterias = new System.Windows.Forms.ComboBox();
            cbxPlanes = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbxEspecialidades = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(17, 532);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(107, 38);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(243, 532);
            btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(107, 38);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 53);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 25);
            label1.TabIndex = 9;
            label1.Text = "Profesor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 432);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 25);
            label4.TabIndex = 18;
            label4.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new System.Drawing.Point(109, 423);
            txtCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new System.Drawing.Size(223, 31);
            txtCargo.TabIndex = 19;
            // 
            // cbxLegajo
            // 
            cbxLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxLegajo.FormattingEnabled = true;
            cbxLegajo.Location = new System.Drawing.Point(121, 48);
            cbxLegajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbxLegajo.Name = "cbxLegajo";
            cbxLegajo.Size = new System.Drawing.Size(210, 33);
            cbxLegajo.TabIndex = 21;
            cbxLegajo.SelectedIndexChanged += cbxLegajo_SelectedIndexChanged;
            // 
            // cbxComision
            // 
            cbxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComision.Enabled = false;
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new System.Drawing.Point(121, 340);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new System.Drawing.Size(210, 33);
            cbxComision.TabIndex = 43;
            cbxComision.SelectedIndexChanged += cbxComision_SelectedIndexChanged;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(27, 350);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(91, 25);
            lblComision.TabIndex = 42;
            lblComision.Text = "Comision:";
            // 
            // cbxMaterias
            // 
            cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMaterias.Enabled = false;
            cbxMaterias.FormattingEnabled = true;
            cbxMaterias.Location = new System.Drawing.Point(121, 263);
            cbxMaterias.Name = "cbxMaterias";
            cbxMaterias.Size = new System.Drawing.Size(210, 33);
            cbxMaterias.TabIndex = 41;
            cbxMaterias.SelectedIndexChanged += cbxMaterias_SelectedIndexChanged;
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(121, 202);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(210, 33);
            cbxPlanes.TabIndex = 40;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(44, 277);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 25);
            label3.TabIndex = 39;
            label3.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 202);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 25);
            label2.TabIndex = 38;
            label2.Text = "Plan:";
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(121, 130);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(210, 33);
            cbxEspecialidades.TabIndex = 37;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 135);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 25);
            label5.TabIndex = 36;
            label5.Text = "Especialidad:";
            // 
            // formAgregarProfesorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(381, 583);
            Controls.Add(cbxComision);
            Controls.Add(lblComision);
            Controls.Add(cbxMaterias);
            Controls.Add(cbxPlanes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxEspecialidades);
            Controls.Add(label5);
            Controls.Add(cbxLegajo);
            Controls.Add(txtCargo);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "formAgregarProfesorCurso";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "formProfesorCurso";
            Load += formAgregarProfesorCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.ComboBox cbxLegajo;
        private System.Windows.Forms.ComboBox cbxComision;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cbxMaterias;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEspecialidades;
        private System.Windows.Forms.Label label5;
    }
}