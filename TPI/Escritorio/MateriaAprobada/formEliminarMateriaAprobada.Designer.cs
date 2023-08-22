namespace Escritorio.MateriaAprobada
{
    partial class formEliminarMateriaAprobada
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
            btnCancelar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            txtIdMateria = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtLegajo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(30, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(200, 171);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new System.Drawing.Point(111, 100);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new System.Drawing.Size(100, 23);
            txtIdMateria.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "idMateria:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(111, 54);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(100, 23);
            txtLegajo.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 9;
            label1.Text = "Legajo:";
            // 
            // formEliminarMateriaAprobada
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(287, 213);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdMateria);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "formEliminarMateriaAprobada";
            Text = "formEliminarMateriaAprobada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
    }
}