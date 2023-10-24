namespace Escritorio
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            label1 = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPass = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnIngresar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(37, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(618, 108);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al Sistema de Gestión Académica!\r\n\r\nDigite su Información de Ingreso";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUsuario.Location = new System.Drawing.Point(192, 213);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(301, 37);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(109, 216);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 29);
            label2.TabIndex = 2;
            label2.Text = "Legajo";
            // 
            // txtPass
            // 
            txtPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPass.Location = new System.Drawing.Point(192, 266);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.Size = new System.Drawing.Size(301, 37);
            txtPass.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(60, 269);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 29);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnIngresar.Location = new System.Drawing.Point(202, 389);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(271, 51);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Iniciar Sesión";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // formLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(691, 476);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresar;
    }
}
