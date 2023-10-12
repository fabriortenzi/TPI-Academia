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
            lblMateria = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtCargo = new System.Windows.Forms.TextBox();
            cbxMateria = new System.Windows.Forms.ComboBox();
            cbxLegajo = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(19, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(144, 240);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new System.Drawing.Point(35, 81);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(41, 15);
            lblMateria.TabIndex = 11;
            lblMateria.Text = "Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 9;
            label1.Text = "Legajo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 132);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new System.Drawing.Point(85, 127);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new System.Drawing.Size(100, 23);
            txtCargo.TabIndex = 19;
            // 
            // cbxMateria
            // 
            cbxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMateria.FormattingEnabled = true;
            cbxMateria.Location = new System.Drawing.Point(85, 78);
            cbxMateria.Name = "cbxMateria";
            cbxMateria.Size = new System.Drawing.Size(100, 23);
            cbxMateria.TabIndex = 20;
            cbxMateria.SelectedIndexChanged += cbxMateria_SelectedIndexChanged;
            cbxMateria.SelectionChangeCommitted += cbxMateria_SelectionChangeCommitted;
            // 
            // cbxLegajo
            // 
            cbxLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxLegajo.FormattingEnabled = true;
            cbxLegajo.Location = new System.Drawing.Point(85, 29);
            cbxLegajo.Name = "cbxLegajo";
            cbxLegajo.Size = new System.Drawing.Size(100, 23);
            cbxLegajo.TabIndex = 21;
            cbxLegajo.SelectedIndexChanged += cbxLegajo_SelectedIndexChanged;
            cbxLegajo.SelectionChangeCommitted += cbxLegajo_SelectionChangeCommitted;
            // 
            // formAgregarProfesorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(245, 284);
            Controls.Add(cbxLegajo);
            Controls.Add(cbxMateria);
            Controls.Add(txtCargo);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(lblMateria);
            Controls.Add(label1);
            Name = "formAgregarProfesorCurso";
            Text = "formProfesorCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.ComboBox cbxLegajo;
    }
}