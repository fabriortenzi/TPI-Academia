namespace Escritorio.Especialidad
{
    partial class formModificarEspecialidad
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
            dgvEspec = new System.Windows.Forms.DataGridView();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnModificar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvEspec).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(113, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(440, 35);
            label1.TabIndex = 0;
            label1.Text = "Seleccione la Especialidad a modificar";
            // 
            // dgvEspec
            // 
            dgvEspec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Descripcion, Id });
            dgvEspec.Location = new System.Drawing.Point(42, 101);
            dgvEspec.Name = "dgvEspec";
            dgvEspec.ReadOnly = true;
            dgvEspec.RowHeadersWidth = 62;
            dgvEspec.RowTemplate.Height = 33;
            dgvEspec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEspec.Size = new System.Drawing.Size(565, 312);
            dgvEspec.TabIndex = 1;
            dgvEspec.DataBindingComplete += dgvEspec_DataBindingComplete;
            dgvEspec.SelectionChanged += dgvEspec_SelectionChanged;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 8;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 500;
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
            // btnModificar
            // 
            btnModificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnModificar.Location = new System.Drawing.Point(356, 476);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(251, 57);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Mofificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(42, 476);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(256, 57);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formModificarEspecialidad
            // 
            AcceptButton = btnModificar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(660, 563);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(dgvEspec);
            Controls.Add(label1);
            Name = "formModificarEspecialidad";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Modificar Especialidad";
            Load += formModificarEspecialidad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEspec;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}