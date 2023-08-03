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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnEditarDatos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitNomApe = new System.Windows.Forms.Label();
            this.lblApeNomPersona = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el DNI de la persona a editar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(194, 83);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(188, 27);
            this.txtDni.TabIndex = 2;
            // 
            // btnEditarDatos
            // 
            this.btnEditarDatos.Enabled = false;
            this.btnEditarDatos.Location = new System.Drawing.Point(332, 268);
            this.btnEditarDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarDatos.Name = "btnEditarDatos";
            this.btnEditarDatos.Size = new System.Drawing.Size(146, 39);
            this.btnEditarDatos.TabIndex = 3;
            this.btnEditarDatos.Text = "Editar Datos";
            this.btnEditarDatos.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(174, 268);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 39);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Persona";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(398, 76);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 39);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblTitNomApe
            // 
            this.lblTitNomApe.AutoSize = true;
            this.lblTitNomApe.Location = new System.Drawing.Point(49, 154);
            this.lblTitNomApe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitNomApe.Name = "lblTitNomApe";
            this.lblTitNomApe.Size = new System.Drawing.Size(139, 20);
            this.lblTitNomApe.TabIndex = 7;
            this.lblTitNomApe.Text = "Apellido y Nombre:";
            this.lblTitNomApe.Visible = false;
            // 
            // lblApeNomPersona
            // 
            this.lblApeNomPersona.AutoSize = true;
            this.lblApeNomPersona.Location = new System.Drawing.Point(194, 154);
            this.lblApeNomPersona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApeNomPersona.Name = "lblApeNomPersona";
            this.lblApeNomPersona.Size = new System.Drawing.Size(127, 20);
            this.lblApeNomPersona.TabIndex = 8;
            this.lblApeNomPersona.Text = "apellidoYNombre";
            this.lblApeNomPersona.Visible = false;
            // 
            // formEditarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 344);
            this.Controls.Add(this.lblApeNomPersona);
            this.Controls.Add(this.lblTitNomApe);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditarDatos);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formEditarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Persona";
            
            this.ResumeLayout(false);
            this.PerformLayout();

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