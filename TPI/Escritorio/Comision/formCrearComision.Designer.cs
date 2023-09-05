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
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(329, 92);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(283, 33);
            cbxEspecialidades.TabIndex = 0;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(225, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(251, 25);
            label1.TabIndex = 1;
            label1.Text = "Complete los siguientes datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(79, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(230, 25);
            label2.TabIndex = 2;
            label2.Text = "Seleccione una Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(84, 143);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(225, 25);
            label3.TabIndex = 3;
            label3.Text = "Ingrese el nro de Comision";
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(370, 223);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(230, 64);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(104, 223);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(230, 64);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNroCom
            // 
            txtNroCom.Location = new System.Drawing.Point(329, 140);
            txtNroCom.Name = "txtNroCom";
            txtNroCom.Size = new System.Drawing.Size(175, 31);
            txtNroCom.TabIndex = 6;
            // 
            // formCrearComision
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(693, 319);
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