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
            lblTitNomApe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitNomApe.Location = new System.Drawing.Point(112, 32);
            lblTitNomApe.Name = "lblTitNomApe";
            lblTitNomApe.Size = new System.Drawing.Size(242, 29);
            lblTitNomApe.TabIndex = 0;
            lblTitNomApe.Text = "Datos modificables de: ";
            // 
            // lblNomApe
            // 
            lblNomApe.AutoSize = true;
            lblNomApe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNomApe.Location = new System.Drawing.Point(360, 32);
            lblNomApe.Name = "lblNomApe";
            lblNomApe.Size = new System.Drawing.Size(174, 29);
            lblNomApe.TabIndex = 1;
            lblNomApe.Text = "nombreApellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(71, 148);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 29);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(79, 209);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(98, 29);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEditar.Location = new System.Drawing.Point(249, 305);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(166, 54);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDireccion.Location = new System.Drawing.Point(183, 145);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(351, 37);
            txtDireccion.TabIndex = 5;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTelefono.Location = new System.Drawing.Point(183, 206);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(351, 37);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // formEditarPersona
            // 
            AcceptButton = btnEditar;
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