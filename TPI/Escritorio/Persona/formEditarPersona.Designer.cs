namespace Escritorio
{
    partial class formEditarPersona
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
            lblTitNomApe = new System.Windows.Forms.Label();
            lblNomApe = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnEditar = new System.Windows.Forms.Button();
            txtDireccion = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblTitNomApe
            // 
            lblTitNomApe.AutoSize = true;
            lblTitNomApe.Location = new System.Drawing.Point(155, 32);
            lblTitNomApe.Name = "lblTitNomApe";
            lblTitNomApe.Size = new System.Drawing.Size(199, 25);
            lblTitNomApe.TabIndex = 0;
            lblTitNomApe.Text = "Datos modificables de: ";
            // 
            // lblNomApe
            // 
            lblNomApe.AutoSize = true;
            lblNomApe.Location = new System.Drawing.Point(360, 32);
            lblNomApe.Name = "lblNomApe";
            lblNomApe.Size = new System.Drawing.Size(141, 25);
            lblNomApe.TabIndex = 1;
            lblNomApe.Text = "nombreApellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(131, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(137, 193);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 25);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new System.Drawing.Point(254, 299);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(166, 54);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(222, 129);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(239, 31);
            txtDireccion.TabIndex = 5;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(222, 190);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(239, 31);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // formEditarPersona
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(664, 407);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNomApe);
            Controls.Add(lblTitNomApe);
            Name = "formEditarPersona";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Editar Persona";
            Load += formEditarPersona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitNomApe;
        private System.Windows.Forms.Label lblNomApe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}