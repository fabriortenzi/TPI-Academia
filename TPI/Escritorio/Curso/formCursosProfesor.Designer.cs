namespace Escritorio.Curso
{
    partial class formCursosProfesor
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
            lblTitulo = new System.Windows.Forms.Label();
            dgvProfCursos = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            usuarioo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfCursos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(58, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(579, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cursos a los que estas asignado en el Ciclo Lectivo";
            // 
            // dgvProfCursos
            // 
            dgvProfCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, usuarioo, Curso, Cargo });
            dgvProfCursos.Location = new System.Drawing.Point(107, 126);
            dgvProfCursos.Name = "dgvProfCursos";
            dgvProfCursos.RowHeadersWidth = 62;
            dgvProfCursos.RowTemplate.Height = 33;
            dgvProfCursos.Size = new System.Drawing.Size(614, 547);
            dgvProfCursos.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 150;
            // 
            // usuarioo
            // 
            usuarioo.DataPropertyName = "Usuario";
            usuarioo.HeaderText = "Usuario";
            usuarioo.MinimumWidth = 8;
            usuarioo.Name = "usuarioo";
            usuarioo.Visible = false;
            usuarioo.Width = 150;
            // 
            // Curso
            // 
            Curso.DataPropertyName = "Curso";
            Curso.HeaderText = "Materia";
            Curso.MinimumWidth = 8;
            Curso.Name = "Curso";
            Curso.Width = 400;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "Cargo";
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 8;
            Cargo.Name = "Cargo";
            Cargo.Width = 150;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCerrar.Location = new System.Drawing.Point(305, 717);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(232, 53);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // formCursosProfesor
            // 
            AcceptButton = btnCerrar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(836, 810);
            Controls.Add(btnCerrar);
            Controls.Add(dgvProfCursos);
            Controls.Add(lblTitulo);
            Name = "formCursosProfesor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cursos Profesor";
            Load += formCursosProfesor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProfCursos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}