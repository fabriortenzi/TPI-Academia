
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtHorasSem = new System.Windows.Forms.TextBox();
            this.txtHorasTot = new System.Windows.Forms.TextBox();
            this.txtNombreMat = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblHorasem = new System.Windows.Forms.Label();
            this.lblHorasTot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(379, 314);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtHorasSem
            // 
            this.txtHorasSem.Location = new System.Drawing.Point(301, 192);
            this.txtHorasSem.Name = "txtHorasSem";
            this.txtHorasSem.Size = new System.Drawing.Size(257, 27);
            this.txtHorasSem.TabIndex = 1;
            this.txtHorasSem.TextChanged += new System.EventHandler(this.txtHorasSem_TextChanged);
            // 
            // txtHorasTot
            // 
            this.txtHorasTot.Location = new System.Drawing.Point(301, 242);
            this.txtHorasTot.Name = "txtHorasTot";
            this.txtHorasTot.Size = new System.Drawing.Size(257, 27);
            this.txtHorasTot.TabIndex = 2;
            this.txtHorasTot.TextChanged += new System.EventHandler(this.txtHorasTot_TextChanged);
            // 
            // txtNombreMat
            // 
            this.txtNombreMat.Location = new System.Drawing.Point(301, 138);
            this.txtNombreMat.Name = "txtNombreMat";
            this.txtNombreMat.Size = new System.Drawing.Size(257, 27);
            this.txtNombreMat.TabIndex = 3;
            this.txtNombreMat.TextChanged += new System.EventHandler(this.txtNombreMat_TextChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(93, 145);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(156, 20);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Nombre de la materia";
            // 
            // lblHorasem
            // 
            this.lblHorasem.AutoSize = true;
            this.lblHorasem.Location = new System.Drawing.Point(92, 195);
            this.lblHorasem.Name = "lblHorasem";
            this.lblHorasem.Size = new System.Drawing.Size(203, 20);
            this.lblHorasem.TabIndex = 5;
            this.lblHorasem.Text = "Cantidad de horas semanales";
            // 
            // lblHorasTot
            // 
            this.lblHorasTot.AutoSize = true;
            this.lblHorasTot.Location = new System.Drawing.Point(93, 245);
            this.lblHorasTot.Name = "lblHorasTot";
            this.lblHorasTot.Size = new System.Drawing.Size(179, 20);
            this.lblHorasTot.TabIndex = 6;
            this.lblHorasTot.Text = "Cantidad de horas totales";
            // 
            // formCrearMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHorasTot);
            this.Controls.Add(this.lblHorasem);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtNombreMat);
            this.Controls.Add(this.txtHorasTot);
            this.Controls.Add(this.txtHorasSem);
            this.Controls.Add(this.btnAceptar);
            this.Name = "formCrearMateria";
            this.Text = "Crear Materia";
            this.Load += new System.EventHandler(this.formCrearMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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