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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtDni = new System.Windows.Forms.TextBox();
            btnEditarDatos = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            lblTitNomApe = new System.Windows.Forms.Label();
            lblApeNomPersona = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(258, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(300, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el DNI de la persona a editar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(185, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 25);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(243, 104);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(234, 31);
            txtDni.TabIndex = 2;
            // 
            // btnEditarDatos
            // 
            btnEditarDatos.Enabled = false;
            btnEditarDatos.Location = new System.Drawing.Point(415, 335);
            btnEditarDatos.Name = "btnEditarDatos";
            btnEditarDatos.Size = new System.Drawing.Size(182, 49);
            btnEditarDatos.TabIndex = 3;
            btnEditarDatos.Text = "Editar Datos";
            btnEditarDatos.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(218, 335);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(182, 49);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar Persona";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(498, 95);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(131, 49);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblTitNomApe
            // 
            lblTitNomApe.AutoSize = true;
            lblTitNomApe.Location = new System.Drawing.Point(61, 193);
            lblTitNomApe.Name = "lblTitNomApe";
            lblTitNomApe.Size = new System.Drawing.Size(167, 25);
            lblTitNomApe.TabIndex = 7;
            lblTitNomApe.Text = "Apellido y Nombre:";
            lblTitNomApe.Visible = false;
            // 
            // lblApeNomPersona
            // 
            lblApeNomPersona.AutoSize = true;
            lblApeNomPersona.Location = new System.Drawing.Point(243, 193);
            lblApeNomPersona.Name = "lblApeNomPersona";
            lblApeNomPersona.Size = new System.Drawing.Size(151, 25);
            lblApeNomPersona.TabIndex = 8;
            lblApeNomPersona.Text = "apellidoYNombre";
            lblApeNomPersona.Visible = false;
            // 
            // formEditarPersona
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(788, 430);
            Controls.Add(lblApeNomPersona);
            Controls.Add(lblTitNomApe);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditarDatos);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formEditarPersona";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Editar Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnEditarDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitNomApe;
        private System.Windows.Forms.Label lblApeNomPersona;
    }
}