﻿namespace Escritorio.ProfesorCurso
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.cbxLegajo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(19, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(144, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(27, 81);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 11;
            this.lblMateria.Text = "Materia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Legajo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(85, 170);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 23);
            this.txtCargo.TabIndex = 19;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(85, 127);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 23);
            this.txtAnio.TabIndex = 17;
            // 
            // cbxMateria
            // 
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(85, 78);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(100, 23);
            this.cbxMateria.TabIndex = 20;
            // 
            // cbxLegajo
            // 
            this.cbxLegajo.FormattingEnabled = true;
            this.cbxLegajo.Location = new System.Drawing.Point(85, 29);
            this.cbxLegajo.Name = "cbxLegajo";
            this.cbxLegajo.Size = new System.Drawing.Size(100, 23);
            this.cbxLegajo.TabIndex = 21;
            // 
            // formAgregarProfesorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 281);
            this.Controls.Add(this.cbxLegajo);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.label1);
            this.Name = "formAgregarProfesorCurso";
            this.Text = "formProfesorCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.ComboBox cbxLegajo;
    }
}