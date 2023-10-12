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
            cbxLegajo = new System.Windows.Forms.ComboBox();
            lblMateria = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cbxCurso = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(22, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(147, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // cbxLegajo
            // 
            cbxLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxLegajo.FormattingEnabled = true;
            cbxLegajo.Location = new System.Drawing.Point(95, 44);
            cbxLegajo.Name = "cbxLegajo";
            cbxLegajo.Size = new System.Drawing.Size(100, 23);
            cbxLegajo.TabIndex = 41;
            cbxLegajo.SelectedIndexChanged += cbxLegajo_SelectedIndexChanged;
            cbxLegajo.SelectionChangeCommitted += cbxLegajo_SelectionChangeCommitted;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new System.Drawing.Point(37, 96);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(41, 15);
            lblMateria.TabIndex = 39;
            lblMateria.Text = "Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 38;
            label1.Text = "Legajo:";
            // 
            // cbxCurso
            // 
            cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCurso.FormattingEnabled = true;
            cbxCurso.Location = new System.Drawing.Point(95, 93);
            cbxCurso.Name = "cbxCurso";
            cbxCurso.Size = new System.Drawing.Size(100, 23);
            cbxCurso.TabIndex = 42;
            cbxCurso.SelectedIndexChanged += cbxCurso_SelectedIndexChanged;
            // 
            // formEliminarProfesorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(245, 245);
            Controls.Add(cbxCurso);
            Controls.Add(cbxLegajo);
            Controls.Add(lblMateria);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Name = "formEliminarProfesorCurso";
            Text = "formEliminarProfesorCurso";
            Load += formEliminarProfesorCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxLegajo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCurso;
    }
}