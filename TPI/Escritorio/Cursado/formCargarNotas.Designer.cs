﻿namespace Escritorio.Cursado
{
    partial class formCargarNotas
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
            dgvCursados = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FechaHoraInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            cbxCursos = new System.Windows.Forms.ComboBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            txtCicloLectivo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCursados).BeginInit();
            SuspendLayout();
            // 
            // dgvCursados
            // 
            dgvCursados.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dgvCursados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Usuario, FechaHoraInscripcion, Curso, NotaFinal });
            dgvCursados.GridColor = System.Drawing.SystemColors.ActiveBorder;
            dgvCursados.Location = new System.Drawing.Point(287, 217);
            dgvCursados.Name = "dgvCursados";
            dgvCursados.RowHeadersWidth = 62;
            dgvCursados.RowTemplate.Height = 33;
            dgvCursados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dgvCursados.Size = new System.Drawing.Size(514, 546);
            dgvCursados.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 150;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 8;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 300;
            // 
            // FechaHoraInscripcion
            // 
            FechaHoraInscripcion.DataPropertyName = "FechaHoraInscripcion";
            FechaHoraInscripcion.HeaderText = "Fecha y hora de inscripcion";
            FechaHoraInscripcion.MinimumWidth = 8;
            FechaHoraInscripcion.Name = "FechaHoraInscripcion";
            FechaHoraInscripcion.ReadOnly = true;
            FechaHoraInscripcion.Visible = false;
            FechaHoraInscripcion.Width = 230;
            // 
            // Curso
            // 
            Curso.DataPropertyName = "Curso";
            Curso.HeaderText = "Curso";
            Curso.MinimumWidth = 8;
            Curso.Name = "Curso";
            Curso.ReadOnly = true;
            Curso.Visible = false;
            Curso.Width = 150;
            // 
            // NotaFinal
            // 
            NotaFinal.DataPropertyName = "NotaFinal";
            NotaFinal.HeaderText = "Nota final";
            NotaFinal.MinimumWidth = 8;
            NotaFinal.Name = "NotaFinal";
            NotaFinal.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(74, 122);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(207, 29);
            label1.TabIndex = 1;
            label1.Text = "Seleccione un curso";
            // 
            // cbxCursos
            // 
            cbxCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCursos.Enabled = false;
            cbxCursos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxCursos.FormattingEnabled = true;
            cbxCursos.Location = new System.Drawing.Point(287, 119);
            cbxCursos.Name = "cbxCursos";
            cbxCursos.Size = new System.Drawing.Size(700, 37);
            cbxCursos.TabIndex = 2;
            cbxCursos.SelectedIndexChanged += cbxCursos_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGuardar.Location = new System.Drawing.Point(585, 800);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(216, 60);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(287, 800);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(211, 60);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCicloLectivo
            // 
            txtCicloLectivo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCicloLectivo.Location = new System.Drawing.Point(330, 47);
            txtCicloLectivo.Name = "txtCicloLectivo";
            txtCicloLectivo.PlaceholderText = "AAAA";
            txtCicloLectivo.Size = new System.Drawing.Size(77, 37);
            txtCicloLectivo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(74, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(234, 29);
            label2.TabIndex = 6;
            label2.Text = "Ingrese el Ciclo Lectivo";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscar.Location = new System.Drawing.Point(483, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(112, 42);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // formCargarNotas
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(1076, 898);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(txtCicloLectivo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cbxCursos);
            Controls.Add(label1);
            Controls.Add(dgvCursados);
            Name = "formCargarNotas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cargar Notas";
            ((System.ComponentModel.ISupportInitialize)dgvCursados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCicloLectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
    }
}