
namespace Escritorio
{
    partial class formInscripcionPlan
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
            comboBoxEspecialidades = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbxPlanes = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAceptar.Location = new System.Drawing.Point(255, 216);
            btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(197, 58);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // comboBoxEspecialidades
            // 
            comboBoxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxEspecialidades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxEspecialidades.FormattingEnabled = true;
            comboBoxEspecialidades.Location = new System.Drawing.Point(350, 66);
            comboBoxEspecialidades.Margin = new System.Windows.Forms.Padding(4);
            comboBoxEspecialidades.Name = "comboBoxEspecialidades";
            comboBoxEspecialidades.Size = new System.Drawing.Size(296, 37);
            comboBoxEspecialidades.TabIndex = 1;
            comboBoxEspecialidades.SelectedIndexChanged += comboBoxEspecialidades_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(54, 69);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(290, 29);
            label1.TabIndex = 2;
            label1.Text = "Seleccione una Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(147, 131);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 29);
            label2.TabIndex = 3;
            label2.Text = "Seleccione un Plan";
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(350, 128);
            cbxPlanes.Margin = new System.Windows.Forms.Padding(4);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(183, 37);
            cbxPlanes.TabIndex = 4;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // formInscripcionPlan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(714, 300);
            Controls.Add(cbxPlanes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxEspecialidades);
            Controls.Add(btnAceptar);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "formInscripcionPlan";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Asignar Plan de Estudio";
            FormClosing += formInscripcionPlan_FormClosing;
            Load += formInscripcionCursado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboBoxEspecialidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPlanes;
    }
}