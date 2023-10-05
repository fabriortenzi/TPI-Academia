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
            label1 = new System.Windows.Forms.Label();
            dgvInscripciones = new System.Windows.Forms.DataGridView();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(296, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(279, 25);
            label1.TabIndex = 0;
            label1.Text = "Inscripciones que puedes eliminar";
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Comision, Materia, Eliminar, Id });
            dgvInscripciones.Location = new System.Drawing.Point(100, 74);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 62;
            dgvInscripciones.RowTemplate.Height = 33;
            dgvInscripciones.Size = new System.Drawing.Size(664, 311);
            dgvInscripciones.TabIndex = 1;
            dgvInscripciones.CellContentClick += dgvInscripciones_CellContentClick;
            // 
            // Comision
            // 
            Comision.DataPropertyName = "IdComision";
            Comision.HeaderText = "Comision";
            Comision.MinimumWidth = 8;
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            Comision.Width = 150;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "descMateria";
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 8;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            Materia.Width = 300;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Eliminar";
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
            // btnCerrar
            // 
            btnCerrar.Location = new System.Drawing.Point(296, 442);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(308, 65);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // formEliminarInscripcion
            // 
            AcceptButton = btnCerrar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(870, 547);
            Controls.Add(btnCerrar);
            Controls.Add(dgvInscripciones);
            Controls.Add(label1);
            Name = "formEliminarInscripcion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Eliminar Inscripcion";
            Load += formEliminarInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}