namespace Escritorio
{
    partial class formNuevoUsuario
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
            cbxTiposDeUsuario = new System.Windows.Forms.ComboBox();
            lblCont = new System.Windows.Forms.Label();
            lblConfCont = new System.Windows.Forms.Label();
            txtContraseña = new System.Windows.Forms.TextBox();
            txtConfContraseña = new System.Windows.Forms.TextBox();
            lblTipUsu = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnCrear = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtDni = new System.Windows.Forms.TextBox();
            btnBuscar = new System.Windows.Forms.Button();
            lblTitApeNom = new System.Windows.Forms.Label();
            lblApellidoNombre = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbxTiposDeUsuario
            // 
            cbxTiposDeUsuario.Enabled = false;
            cbxTiposDeUsuario.FormattingEnabled = true;
            cbxTiposDeUsuario.Location = new System.Drawing.Point(387, 222);
            cbxTiposDeUsuario.Name = "cbxTiposDeUsuario";
            cbxTiposDeUsuario.Size = new System.Drawing.Size(246, 33);
            cbxTiposDeUsuario.TabIndex = 0;
            // 
            // lblCont
            // 
            lblCont.AutoSize = true;
            lblCont.Enabled = false;
            lblCont.Location = new System.Drawing.Point(258, 287);
            lblCont.Name = "lblCont";
            lblCont.Size = new System.Drawing.Size(101, 25);
            lblCont.TabIndex = 1;
            lblCont.Text = "Contraseña";
            // 
            // lblConfCont
            // 
            lblConfCont.AutoSize = true;
            lblConfCont.Enabled = false;
            lblConfCont.Location = new System.Drawing.Point(174, 340);
            lblConfCont.Name = "lblConfCont";
            lblConfCont.Size = new System.Drawing.Size(185, 25);
            lblConfCont.TabIndex = 2;
            lblConfCont.Text = "Confirmar Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new System.Drawing.Point(387, 284);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '●';
            txtContraseña.Size = new System.Drawing.Size(246, 31);
            txtContraseña.TabIndex = 3;
            // 
            // txtConfContraseña
            // 
            txtConfContraseña.Enabled = false;
            txtConfContraseña.Location = new System.Drawing.Point(387, 337);
            txtConfContraseña.Name = "txtConfContraseña";
            txtConfContraseña.PasswordChar = '●';
            txtConfContraseña.Size = new System.Drawing.Size(246, 31);
            txtConfContraseña.TabIndex = 4;
            // 
            // lblTipUsu
            // 
            lblTipUsu.AutoSize = true;
            lblTipUsu.Enabled = false;
            lblTipUsu.Location = new System.Drawing.Point(110, 225);
            lblTipUsu.Name = "lblTipUsu";
            lblTipUsu.Size = new System.Drawing.Size(249, 25);
            lblTipUsu.TabIndex = 5;
            lblTipUsu.Text = "Seleccione un Tipo de Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(297, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(251, 25);
            label4.TabIndex = 6;
            label4.Text = "Complete los siguientes datos";
            // 
            // btnCrear
            // 
            btnCrear.Enabled = false;
            btnCrear.Location = new System.Drawing.Point(331, 408);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(149, 45);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(65, 102);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(234, 25);
            label5.TabIndex = 8;
            label5.Text = "Ingrese el DNI de la Persona";
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(327, 99);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(246, 31);
            txtDni.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(595, 92);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(149, 45);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblTitApeNom
            // 
            lblTitApeNom.AutoSize = true;
            lblTitApeNom.Enabled = false;
            lblTitApeNom.Location = new System.Drawing.Point(192, 174);
            lblTitApeNom.Name = "lblTitApeNom";
            lblTitApeNom.Size = new System.Drawing.Size(167, 25);
            lblTitApeNom.TabIndex = 11;
            lblTitApeNom.Text = "Apellido y Nombre:";
            // 
            // lblApellidoNombre
            // 
            lblApellidoNombre.AutoSize = true;
            lblApellidoNombre.Enabled = false;
            lblApellidoNombre.Location = new System.Drawing.Point(385, 174);
            lblApellidoNombre.Name = "lblApellidoNombre";
            lblApellidoNombre.Size = new System.Drawing.Size(59, 25);
            lblApellidoNombre.TabIndex = 12;
            lblApellidoNombre.Text = "label7";
            lblApellidoNombre.Visible = false;
            // 
            // formNuevoUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(818, 523);
            Controls.Add(lblApellidoNombre);
            Controls.Add(lblTitApeNom);
            Controls.Add(btnBuscar);
            Controls.Add(txtDni);
            Controls.Add(label5);
            Controls.Add(btnCrear);
            Controls.Add(label4);
            Controls.Add(lblTipUsu);
            Controls.Add(txtConfContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(lblConfCont);
            Controls.Add(lblCont);
            Controls.Add(cbxTiposDeUsuario);
            Name = "formNuevoUsuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Nuevo Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTiposDeUsuario;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblConfCont;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtConfContraseña;
        private System.Windows.Forms.Label lblTipUsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitApeNom;
        private System.Windows.Forms.Label lblApellidoNombre;
    }
}