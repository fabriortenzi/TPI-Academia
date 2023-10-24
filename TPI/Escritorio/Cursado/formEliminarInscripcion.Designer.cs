namespace Escritorio.Inscripcion
{
    partial class formEliminarInscripcion
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            btnCerrar = new System.Windows.Forms.Button();
            cursadoBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvInscripciones = new System.Windows.Forms.DataGridView();
            Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FechaHoraInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            usuarioe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cursadoBindingSource1 = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)cursadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursadoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(351, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(279, 25);
            label1.TabIndex = 0;
            label1.Text = "Inscripciones que puedes eliminar";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new System.Drawing.Point(351, 566);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(308, 65);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cursadoBindingSource
            // 
            cursadoBindingSource.DataSource = typeof(TPI.Entidades.Cursado);
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Curso, FechaHoraInscripcion, Eliminar, Id, usuarioe, NotaFinal });
            dgvInscripciones.Location = new System.Drawing.Point(60, 79);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 62;
            dgvInscripciones.RowTemplate.Height = 33;
            dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dgvInscripciones.Size = new System.Drawing.Size(884, 440);
            dgvInscripciones.TabIndex = 3;
            dgvInscripciones.CellContentClick += dgvInscripciones_CellContentClick;
            // 
            // Curso
            // 
            Curso.DataPropertyName = "Curso";
            Curso.HeaderText = "Materia";
            Curso.MinimumWidth = 8;
            Curso.Name = "Curso";
            Curso.Width = 400;
            // 
            // FechaHoraInscripcion
            // 
            FechaHoraInscripcion.DataPropertyName = "FechaHoraInscripcion";
            FechaHoraInscripcion.HeaderText = "Fecha y hora de inscripcion";
            FechaHoraInscripcion.MinimumWidth = 8;
            FechaHoraInscripcion.Name = "FechaHoraInscripcion";
            FechaHoraInscripcion.Width = 270;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Eliminar";
            Eliminar.ToolTipText = "Eliminar";
            Eliminar.UseColumnTextForLinkValue = true;
            Eliminar.Width = 150;
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
            // usuarioe
            // 
            usuarioe.DataPropertyName = "Usuario";
            usuarioe.HeaderText = "usuario";
            usuarioe.MinimumWidth = 8;
            usuarioe.Name = "usuarioe";
            usuarioe.Visible = false;
            usuarioe.Width = 150;
            // 
            // NotaFinal
            // 
            NotaFinal.DataPropertyName = "NotaFinal";
            NotaFinal.HeaderText = "NotaFinal";
            NotaFinal.MinimumWidth = 8;
            NotaFinal.Name = "NotaFinal";
            NotaFinal.Visible = false;
            NotaFinal.Width = 150;
            // 
            // cursadoBindingSource1
            // 
            cursadoBindingSource1.DataSource = typeof(TPI.Entidades.Cursado);
            // 
            // formEliminarInscripcion
            // 
            AcceptButton = btnCerrar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1004, 666);
            Controls.Add(dgvInscripciones);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Name = "formEliminarInscripcion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Eliminar Inscripcion";
            Load += formEliminarInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)cursadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursadoBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.BindingSource cursadoBindingSource;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.BindingSource cursadoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraInscripcion;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
    }
}