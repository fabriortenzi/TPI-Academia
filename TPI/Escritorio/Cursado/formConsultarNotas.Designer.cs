namespace Escritorio.Cursado
{
    partial class formConsultarNotas
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
            dgvCursados = new System.Windows.Forms.DataGridView();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FechaHoraInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCursados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(383, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(240, 35);
            label1.TabIndex = 0;
            label1.Text = "Notas de tus Cursos";
            // 
            // dgvCursados
            // 
            dgvCursados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Materia, Id, Usuario, NotaFinal, FechaHoraInscripcion });
            dgvCursados.Location = new System.Drawing.Point(48, 89);
            dgvCursados.Name = "dgvCursados";
            dgvCursados.RowHeadersWidth = 62;
            dgvCursados.RowTemplate.Height = 33;
            dgvCursados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dgvCursados.Size = new System.Drawing.Size(884, 582);
            dgvCursados.TabIndex = 1;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "Curso";
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 8;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            Materia.Width = 400;
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
            Usuario.Visible = false;
            Usuario.Width = 150;
            // 
            // NotaFinal
            // 
            NotaFinal.DataPropertyName = "NotaFinal";
            NotaFinal.HeaderText = "Nota final";
            NotaFinal.MinimumWidth = 8;
            NotaFinal.Name = "NotaFinal";
            NotaFinal.ReadOnly = true;
            NotaFinal.Width = 150;
            // 
            // FechaHoraInscripcion
            // 
            FechaHoraInscripcion.DataPropertyName = "FechaHoraInscripcion";
            FechaHoraInscripcion.HeaderText = "Fecha y hora de inscripcion";
            FechaHoraInscripcion.MinimumWidth = 8;
            FechaHoraInscripcion.Name = "FechaHoraInscripcion";
            FechaHoraInscripcion.ReadOnly = true;
            FechaHoraInscripcion.Width = 270;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCerrar.Location = new System.Drawing.Point(359, 722);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(264, 63);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // formConsultarNotas
            // 
            AcceptButton = btnCerrar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCerrar;
            ClientSize = new System.Drawing.Size(992, 830);
            Controls.Add(btnCerrar);
            Controls.Add(dgvCursados);
            Controls.Add(label1);
            Name = "formConsultarNotas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Consultar Notas";
            Load += formConsultarNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCursados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCursados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraInscripcion;
    }
}