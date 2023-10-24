namespace Escritorio.ProfesorCurso
{
    partial class formEliminarProfesorCurso
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
            btnEliminar = new System.Windows.Forms.Button();
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
            btnCancelar.Location = new System.Drawing.Point(36, 478);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(107, 38);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(214, 478);
            btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(107, 38);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // cbxComision
            // 
            cbxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComision.Enabled = false;
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new System.Drawing.Point(127, 333);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new System.Drawing.Size(210, 33);
            cbxComision.TabIndex = 53;
            cbxComision.SelectedIndexChanged += cbxComision_SelectedIndexChanged;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(33, 343);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(91, 25);
            lblComision.TabIndex = 52;
            lblComision.Text = "Comision:";
            // 
            // cbxMaterias
            // 
            cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMaterias.Enabled = false;
            cbxMaterias.FormattingEnabled = true;
            cbxMaterias.Location = new System.Drawing.Point(127, 257);
            cbxMaterias.Name = "cbxMaterias";
            cbxMaterias.Size = new System.Drawing.Size(210, 33);
            cbxMaterias.TabIndex = 51;
            cbxMaterias.SelectedIndexChanged += cbxMaterias_SelectedIndexChanged;
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(127, 195);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(210, 33);
            cbxPlanes.TabIndex = 50;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(50, 270);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 25);
            label3.TabIndex = 49;
            label3.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(74, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 25);
            label2.TabIndex = 48;
            label2.Text = "Plan:";
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(127, 123);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(210, 33);
            cbxEspecialidades.TabIndex = 47;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 128);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 25);
            label5.TabIndex = 46;
            label5.Text = "Especialidad:";
            // 
            // cbxLegajo
            // 
            cbxLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxLegajo.FormattingEnabled = true;
            cbxLegajo.Location = new System.Drawing.Point(127, 42);
            cbxLegajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbxLegajo.Name = "cbxLegajo";
            cbxLegajo.Size = new System.Drawing.Size(210, 33);
            cbxLegajo.TabIndex = 45;
            cbxLegajo.SelectedIndexChanged += cbxLegajo_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 47);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 25);
            label1.TabIndex = 44;
            label1.Text = "Profesor:";
            // 
            // formEliminarProfesorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(364, 563);
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
            Controls.Add(btnEliminar);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "formEliminarProfesorCurso";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "formEliminarProfesorCurso";
            Load += formEliminarProfesorCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
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