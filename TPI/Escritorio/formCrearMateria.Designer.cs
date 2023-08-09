
namespace Escritorio
{
    partial class formCrearMateria
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
            btnAceptar = new System.Windows.Forms.Button();
            txtHorasSem = new System.Windows.Forms.TextBox();
            txtHorasTot = new System.Windows.Forms.TextBox();
            txtNombreMat = new System.Windows.Forms.TextBox();
            lblDesc = new System.Windows.Forms.Label();
            lblHorasem = new System.Windows.Forms.Label();
            lblHorasTot = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new System.Drawing.Point(474, 392);
            btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(118, 36);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtHorasSem
            // 
            txtHorasSem.Location = new System.Drawing.Point(376, 240);
            txtHorasSem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtHorasSem.Name = "txtHorasSem";
            txtHorasSem.Size = new System.Drawing.Size(320, 31);
            txtHorasSem.TabIndex = 1;
            txtHorasSem.TextChanged += txtHorasSem_TextChanged;
            // 
            // txtHorasTot
            // 
            txtHorasTot.Location = new System.Drawing.Point(376, 302);
            txtHorasTot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtHorasTot.Name = "txtHorasTot";
            txtHorasTot.Size = new System.Drawing.Size(320, 31);
            txtHorasTot.TabIndex = 2;
            txtHorasTot.TextChanged += txtHorasTot_TextChanged;
            // 
            // txtNombreMat
            // 
            txtNombreMat.Location = new System.Drawing.Point(376, 172);
            txtNombreMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtNombreMat.Name = "txtNombreMat";
            txtNombreMat.Size = new System.Drawing.Size(320, 31);
            txtNombreMat.TabIndex = 3;
            txtNombreMat.TextChanged += txtNombreMat_TextChanged;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new System.Drawing.Point(116, 181);
            lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new System.Drawing.Size(185, 25);
            lblDesc.TabIndex = 4;
            lblDesc.Text = "Nombre de la materia";
            // 
            // lblHorasem
            // 
            lblHorasem.AutoSize = true;
            lblHorasem.Location = new System.Drawing.Point(115, 244);
            lblHorasem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHorasem.Name = "lblHorasem";
            lblHorasem.Size = new System.Drawing.Size(244, 25);
            lblHorasem.TabIndex = 5;
            lblHorasem.Text = "Cantidad de horas semanales";
            // 
            // lblHorasTot
            // 
            lblHorasTot.AutoSize = true;
            lblHorasTot.Location = new System.Drawing.Point(116, 306);
            lblHorasTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHorasTot.Name = "lblHorasTot";
            lblHorasTot.Size = new System.Drawing.Size(215, 25);
            lblHorasTot.TabIndex = 6;
            lblHorasTot.Text = "Cantidad de horas totales";
            // 
            // formCrearMateria
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 562);
            Controls.Add(lblHorasTot);
            Controls.Add(lblHorasem);
            Controls.Add(lblDesc);
            Controls.Add(txtNombreMat);
            Controls.Add(txtHorasTot);
            Controls.Add(txtHorasSem);
            Controls.Add(btnAceptar);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "formCrearMateria";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Crear Materia";
            Load += formCrearMateria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtHorasSem;
        private System.Windows.Forms.TextBox txtHorasTot;
        private System.Windows.Forms.TextBox txtNombreMat;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblHorasem;
        private System.Windows.Forms.Label lblHorasTot;
    }
}