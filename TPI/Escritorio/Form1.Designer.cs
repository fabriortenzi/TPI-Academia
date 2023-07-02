namespace Escritorio
{
    partial class Form1
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
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(317, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al Sistema";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(295, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(261, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(181, 163);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(295, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(261, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(181, 215);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(342, 320);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(159, 34);
            button1.TabIndex = 5;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sistema de Gestion Academica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
