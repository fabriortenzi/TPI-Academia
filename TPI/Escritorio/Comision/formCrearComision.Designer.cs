namespace Escritorio.Comision
{
    partial class formCrearComision
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
            cbxEspecialidades = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnCrear = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            txtNroCom = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(371, 124);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(283, 37);
            cbxEspecialidades.TabIndex = 0;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(213, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(352, 35);
            label1.TabIndex = 1;
            label1.Text = "Complete los siguientes datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(75, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(290, 29);
            label2.TabIndex = 2;
            label2.Text = "Seleccione una Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(92, 175);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(273, 29);
            label3.TabIndex = 3;
            label3.Text = "Ingrese el nro de Comision";
            // 
            // btnCrear
            // 
            btnCrear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCrear.Location = new System.Drawing.Point(401, 266);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(212, 50);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(135, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(214, 50);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNroCom
            // 
            txtNroCom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNroCom.Location = new System.Drawing.Point(371, 172);
            txtNroCom.Name = "txtNroCom";
            txtNroCom.Size = new System.Drawing.Size(175, 37);
            txtNroCom.TabIndex = 6;
            // 
            // formCrearComision
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(742, 371);
            Controls.Add(txtNroCom);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxEspecialidades);
            Name = "formCrearComision";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Crear Comision";
            Load += formCrearComision_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEspecialidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNroCom;
    }
}