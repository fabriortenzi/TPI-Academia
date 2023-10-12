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
            Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)cursadoBindingSource).BeginInit();
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
            // cursadoBindingSource
            // 
            cursadoBindingSource.DataSource = typeof(TPI.Entidades.Cursado);
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Eliminar });
            dgvInscripciones.Location = new System.Drawing.Point(60, 114);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 62;
            dgvInscripciones.RowTemplate.Height = 33;
            dgvInscripciones.Size = new System.Drawing.Size(896, 212);
            dgvInscripciones.TabIndex = 3;
            dgvInscripciones.CellContentClick += dgvInscripciones_CellContentClick;
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
            // formEliminarInscripcion
            // 
            AcceptButton = btnCerrar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1051, 547);
            Controls.Add(dgvInscripciones);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Name = "formEliminarInscripcion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Eliminar Inscripcion";
            Load += formEliminarInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)cursadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.BindingSource cursadoBindingSource;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}