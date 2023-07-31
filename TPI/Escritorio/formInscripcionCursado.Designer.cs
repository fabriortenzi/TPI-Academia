
namespace Escritorio
{
    partial class formInscripcionCursado
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.comboBoxEspecialidades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(324, 280);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // comboBoxEspecialidades
            // 
            this.comboBoxEspecialidades.FormattingEnabled = true;
            this.comboBoxEspecialidades.Location = new System.Drawing.Point(298, 207);
            this.comboBoxEspecialidades.Name = "comboBoxEspecialidades";
            this.comboBoxEspecialidades.Size = new System.Drawing.Size(151, 28);
            this.comboBoxEspecialidades.TabIndex = 1;
            this.comboBoxEspecialidades.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspecialidades_SelectedIndexChanged);
            // 
            // formInscripcionCursado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxEspecialidades);
            this.Controls.Add(this.btnAceptar);
            this.Name = "formInscripcionCursado";
            this.Text = "InscripcionCursado";
            this.Load += new System.EventHandler(this.formInscripcionCursado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboBoxEspecialidades;
    }
}