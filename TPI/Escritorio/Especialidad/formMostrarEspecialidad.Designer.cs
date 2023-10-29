namespace Escritorio.Especialidad
{
    partial class formMostrarEspecialidad
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
            btnModificar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblDesc = new System.Windows.Forms.Label();
            lblId = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnModificar.Location = new System.Drawing.Point(146, 154);
            btnModificar.Margin = new System.Windows.Forms.Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(164, 34);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(118, 87);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 19);
            label2.TabIndex = 6;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(134, 23);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(176, 23);
            label1.TabIndex = 5;
            label1.Text = "Datos de especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(180, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(20, 15);
            label3.TabIndex = 10;
            label3.Text = "Id:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new System.Drawing.Point(250, 88);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new System.Drawing.Size(38, 15);
            lblDesc.TabIndex = 11;
            lblDesc.Text = "label4";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(250, 62);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(38, 15);
            lblId.TabIndex = 12;
            lblId.Text = "label5";
            // 
            // formMostrarEspecialidad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(453, 199);
            Controls.Add(lblId);
            Controls.Add(lblDesc);
            Controls.Add(label3);
            Controls.Add(btnModificar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formMostrarEspecialidad";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "formMostrarEspecialidad";
            Load += formMostrarEspecialidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblId;
    }
}