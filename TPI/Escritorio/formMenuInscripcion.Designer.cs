
namespace Escritorio
{
    partial class formMenuInscripcion
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
            this.listBoxEspecialidades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxEspecialidades
            // 
            this.listBoxEspecialidades.FormattingEnabled = true;
            this.listBoxEspecialidades.ItemHeight = 20;
            this.listBoxEspecialidades.Location = new System.Drawing.Point(315, 140);
            this.listBoxEspecialidades.Name = "listBoxEspecialidades";
            this.listBoxEspecialidades.Size = new System.Drawing.Size(150, 104);
            this.listBoxEspecialidades.TabIndex = 0;
            // 
            // formMenuInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxEspecialidades);
            this.Name = "formMenuInscripcion";
            this.Text = "Menu Inscripcion";
            this.Load += new System.EventHandler(this.formMenuInscripcion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEspecialidades;
    }
}