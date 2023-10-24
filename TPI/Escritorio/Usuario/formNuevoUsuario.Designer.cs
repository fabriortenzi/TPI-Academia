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
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cbxTiposDeUsuario
            // 
            cbxTiposDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxTiposDeUsuario.Enabled = false;
            cbxTiposDeUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxTiposDeUsuario.FormattingEnabled = true;
            cbxTiposDeUsuario.Location = new System.Drawing.Point(387, 252);
            cbxTiposDeUsuario.Name = "cbxTiposDeUsuario";
            cbxTiposDeUsuario.Size = new System.Drawing.Size(324, 37);
            cbxTiposDeUsuario.TabIndex = 0;
            // 
            // lblCont
            // 
            lblCont.AutoSize = true;
            lblCont.Enabled = false;
            lblCont.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCont.Location = new System.Drawing.Point(255, 312);
            lblCont.Name = "lblCont";
            lblCont.Size = new System.Drawing.Size(126, 29);
            lblCont.TabIndex = 1;
            lblCont.Text = "Contraseña";
            // 
            // lblConfCont
            // 
            lblConfCont.AutoSize = true;
            lblConfCont.Enabled = false;
            lblConfCont.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblConfCont.Location = new System.Drawing.Point(151, 370);
            lblConfCont.Name = "lblConfCont";
            lblConfCont.Size = new System.Drawing.Size(230, 29);
            lblConfCont.TabIndex = 2;
            lblConfCont.Text = "Confirmar Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtContraseña.Location = new System.Drawing.Point(387, 309);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '●';
            txtContraseña.Size = new System.Drawing.Size(324, 37);
            txtContraseña.TabIndex = 3;
            // 
            // txtConfContraseña
            // 
            txtConfContraseña.Enabled = false;
            txtConfContraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtConfContraseña.Location = new System.Drawing.Point(387, 367);
            txtConfContraseña.Name = "txtConfContraseña";
            txtConfContraseña.PasswordChar = '●';
            txtConfContraseña.Size = new System.Drawing.Size(324, 37);
            txtConfContraseña.TabIndex = 4;
            // 
            // lblTipUsu
            // 
            lblTipUsu.AutoSize = true;
            lblTipUsu.Enabled = false;
            lblTipUsu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTipUsu.Location = new System.Drawing.Point(70, 255);
            lblTipUsu.Name = "lblTipUsu";
            lblTipUsu.Size = new System.Drawing.Size(309, 29);
            lblTipUsu.TabIndex = 5;
            lblTipUsu.Text = "Seleccione un Tipo de Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(297, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(352, 35);
            label4.TabIndex = 6;
            label4.Text = "Complete los siguientes datos";
            // 
            // btnCrear
            // 
            btnCrear.Enabled = false;
            btnCrear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCrear.Location = new System.Drawing.Point(562, 478);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(263, 70);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(93, 102);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(286, 29);
            label5.TabIndex = 8;
            label5.Text = "Ingrese el DNI de la Persona";
            // 
            // txtDni
            // 
            txtDni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDni.Location = new System.Drawing.Point(385, 99);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(326, 37);
            txtDni.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscar.Location = new System.Drawing.Point(732, 94);
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
            lblTitApeNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitApeNom.Location = new System.Drawing.Point(175, 204);
            lblTitApeNom.Name = "lblTitApeNom";
            lblTitApeNom.Size = new System.Drawing.Size(204, 29);
            lblTitApeNom.TabIndex = 11;
            lblTitApeNom.Text = "Apellido y Nombre:";
            // 
            // lblApellidoNombre
            // 
            lblApellidoNombre.AutoSize = true;
            lblApellidoNombre.Enabled = false;
            lblApellidoNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblApellidoNombre.Location = new System.Drawing.Point(387, 204);
            lblApellidoNombre.Name = "lblApellidoNombre";
            lblApellidoNombre.Size = new System.Drawing.Size(74, 29);
            lblApellidoNombre.TabIndex = 12;
            lblApellidoNombre.Text = "label7";
            lblApellidoNombre.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(170, 478);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(257, 70);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formNuevoUsuario
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(997, 596);
            Controls.Add(btnCancelar);
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
        private System.Windows.Forms.Button btnCancelar;
    }
}