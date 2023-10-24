namespace Escritorio
{
    partial class formCambiarContraseña
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
            lblContraseña = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtCnt = new System.Windows.Forms.TextBox();
            txtNuevCont = new System.Windows.Forms.TextBox();
            txtConf = new System.Windows.Forms.TextBox();
            btnCambiar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblContraseña.Location = new System.Drawing.Point(123, 65);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new System.Drawing.Size(126, 29);
            lblContraseña.TabIndex = 0;
            lblContraseña.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(54, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(195, 29);
            label2.TabIndex = 1;
            label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(22, 161);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(230, 29);
            label3.TabIndex = 2;
            label3.Text = "Confirmar Contraseña";
            // 
            // txtCnt
            // 
            txtCnt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCnt.Location = new System.Drawing.Point(255, 62);
            txtCnt.Name = "txtCnt";
            txtCnt.PasswordChar = '●';
            txtCnt.Size = new System.Drawing.Size(294, 37);
            txtCnt.TabIndex = 3;
            // 
            // txtNuevCont
            // 
            txtNuevCont.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNuevCont.Location = new System.Drawing.Point(255, 110);
            txtNuevCont.Name = "txtNuevCont";
            txtNuevCont.PasswordChar = '●';
            txtNuevCont.Size = new System.Drawing.Size(294, 37);
            txtNuevCont.TabIndex = 4;
            // 
            // txtConf
            // 
            txtConf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtConf.Location = new System.Drawing.Point(255, 158);
            txtConf.Name = "txtConf";
            txtConf.PasswordChar = '●';
            txtConf.Size = new System.Drawing.Size(294, 37);
            txtConf.TabIndex = 5;
            // 
            // btnCambiar
            // 
            btnCambiar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCambiar.Location = new System.Drawing.Point(176, 257);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new System.Drawing.Size(246, 59);
            btnCambiar.TabIndex = 6;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // formCambiarContraseña
            // 
            AcceptButton = btnCambiar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(603, 352);
            Controls.Add(btnCambiar);
            Controls.Add(txtConf);
            Controls.Add(txtNuevCont);
            Controls.Add(txtCnt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblContraseña);
            Name = "formCambiarContraseña";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cambiar Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCnt;
        private System.Windows.Forms.TextBox txtNuevCont;
        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.Button btnCambiar;
    }
}