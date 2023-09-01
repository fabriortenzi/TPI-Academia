
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
            textBoxAño = new System.Windows.Forms.TextBox();
            textBoxDesc = new System.Windows.Forms.TextBox();
            lblAño = new System.Windows.Forms.Label();
            lblDesc = new System.Windows.Forms.Label();
            btnAceptar = new System.Windows.Forms.Button();
            comboBoxEsp = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBoxAño
            // 
            textBoxAño.Location = new System.Drawing.Point(299, 126);
            textBoxAño.Margin = new System.Windows.Forms.Padding(4);
            textBoxAño.Name = "textBoxAño";
            textBoxAño.Size = new System.Drawing.Size(155, 31);
            textBoxAño.TabIndex = 0;
            textBoxAño.TextChanged += textBoxAño_TextChanged;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new System.Drawing.Point(299, 200);
            textBoxDesc.Margin = new System.Windows.Forms.Padding(4);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new System.Drawing.Size(155, 31);
            textBoxDesc.TabIndex = 1;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new System.Drawing.Point(129, 134);
            lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAño.Name = "lblAño";
            lblAño.Size = new System.Drawing.Size(45, 25);
            lblAño.TabIndex = 2;
            lblAño.Text = "Año";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new System.Drawing.Point(129, 209);
            lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new System.Drawing.Size(104, 25);
            lblDesc.TabIndex = 3;
            lblDesc.Text = "Descripcion";
            lblDesc.Click += label2_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new System.Drawing.Point(402, 360);
            btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(262, 71);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // comboBoxEsp
            // 
            comboBoxEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxEsp.FormattingEnabled = true;
            comboBoxEsp.Location = new System.Drawing.Point(299, 276);
            comboBoxEsp.Margin = new System.Windows.Forms.Padding(4);
            comboBoxEsp.Name = "comboBoxEsp";
            comboBoxEsp.Size = new System.Drawing.Size(299, 33);
            comboBoxEsp.TabIndex = 5;
            comboBoxEsp.SelectedIndexChanged += comboBoxEsp_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(129, 278);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 25);
            label1.TabIndex = 6;
            label1.Text = "Especialidad";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(260, 30);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(251, 25);
            label2.TabIndex = 7;
            label2.Text = "Complete los siguientes datos";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(107, 360);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(262, 71);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formAgregoPlan
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(771, 467);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxEsp);
            Controls.Add(btnAceptar);
            Controls.Add(lblDesc);
            Controls.Add(lblAño);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxAño);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "formAgregoPlan";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Agrego Plan";
            Load += formAgregoPlan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAño;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboBoxEsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
    }
}