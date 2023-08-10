
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
            this.cbxEspecialidades = new System.Windows.Forms.ComboBox();
            this.cbxPlanes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescMateria = new System.Windows.Forms.TextBox();
            this.txtHorasSem = new System.Windows.Forms.TextBox();
            this.txtHorasTot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxEspecialidades
            // 
            this.cbxEspecialidades.FormattingEnabled = true;
            this.cbxEspecialidades.Location = new System.Drawing.Point(357, 62);
            this.cbxEspecialidades.Name = "cbxEspecialidades";
            this.cbxEspecialidades.Size = new System.Drawing.Size(151, 28);
            this.cbxEspecialidades.TabIndex = 0;
            this.cbxEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cbxEspecialidades_SelectedIndexChanged);
            // 
            // cbxPlanes
            // 
            this.cbxPlanes.Enabled = false;
            this.cbxPlanes.FormattingEnabled = true;
            this.cbxPlanes.Location = new System.Drawing.Point(357, 117);
            this.cbxPlanes.Name = "cbxPlanes";
            this.cbxPlanes.Size = new System.Drawing.Size(151, 28);
            this.cbxPlanes.TabIndex = 1;
            this.cbxPlanes.SelectedIndexChanged += new System.EventHandler(this.cbxPlanes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plan";
            // 
            // txtDescMateria
            // 
            this.txtDescMateria.Location = new System.Drawing.Point(357, 181);
            this.txtDescMateria.Name = "txtDescMateria";
            this.txtDescMateria.Size = new System.Drawing.Size(151, 27);
            this.txtDescMateria.TabIndex = 4;
            this.txtDescMateria.TextChanged += new System.EventHandler(this.txtDescMateria_TextChanged);
            // 
            // txtHorasSem
            // 
            this.txtHorasSem.Location = new System.Drawing.Point(357, 242);
            this.txtHorasSem.Name = "txtHorasSem";
            this.txtHorasSem.Size = new System.Drawing.Size(151, 27);
            this.txtHorasSem.TabIndex = 5;
            this.txtHorasSem.TextChanged += new System.EventHandler(this.txtHorasSem_TextChanged);
            // 
            // txtHorasTot
            // 
            this.txtHorasTot.Location = new System.Drawing.Point(357, 304);
            this.txtHorasTot.Name = "txtHorasTot";
            this.txtHorasTot.Size = new System.Drawing.Size(151, 27);
            this.txtHorasTot.TabIndex = 6;
            this.txtHorasTot.TextChanged += new System.EventHandler(this.txtHorasTot_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de la materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horas semanales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Horas Totales";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(357, 383);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(151, 29);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // formCrearMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorasTot);
            this.Controls.Add(this.txtHorasSem);
            this.Controls.Add(this.txtDescMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPlanes);
            this.Controls.Add(this.cbxEspecialidades);
            this.Name = "formCrearMateria";
            this.Text = "Crear Materia";
            this.Load += new System.EventHandler(this.formCrearMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEspecialidades;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescMateria;
        private System.Windows.Forms.TextBox txtHorasSem;
        private System.Windows.Forms.TextBox txtHorasTot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrear;
    }
}