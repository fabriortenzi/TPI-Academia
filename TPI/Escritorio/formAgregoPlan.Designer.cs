
namespace Escritorio
{
    partial class formAgregoPlan
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
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.comboBoxEsp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAño
            // 
            this.textBoxAño.Location = new System.Drawing.Point(306, 70);
            this.textBoxAño.Name = "textBoxAño";
            this.textBoxAño.Size = new System.Drawing.Size(125, 27);
            this.textBoxAño.TabIndex = 0;
            this.textBoxAño.TextChanged += new System.EventHandler(this.textBoxAño_TextChanged);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(306, 130);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(125, 27);
            this.textBoxDesc.TabIndex = 1;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(170, 77);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(36, 20);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(170, 137);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(87, 20);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Descripcion";
            this.lblDesc.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(320, 280);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEsp
            // 
            this.comboBoxEsp.FormattingEnabled = true;
            this.comboBoxEsp.Location = new System.Drawing.Point(306, 190);
            this.comboBoxEsp.Name = "comboBoxEsp";
            this.comboBoxEsp.Size = new System.Drawing.Size(240, 28);
            this.comboBoxEsp.TabIndex = 5;
            this.comboBoxEsp.SelectedIndexChanged += new System.EventHandler(this.comboBoxEsp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Especialidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formAgregoPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEsp);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxAño);
            this.Name = "formAgregoPlan";
            this.Text = "Agrego Plan";
            this.Load += new System.EventHandler(this.formAgregoPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAño;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboBoxEsp;
        private System.Windows.Forms.Label label1;
    }
}