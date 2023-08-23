namespace Escritorio.MateriaComision
{
    partial class formEliminarMateriaComision
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
            txtIdComision = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtIdMateria = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtidEspecialidad = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtIdComision
            // 
            txtIdComision.Location = new System.Drawing.Point(125, 103);
            txtIdComision.Name = "txtIdComision";
            txtIdComision.Size = new System.Drawing.Size(100, 23);
            txtIdComision.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(48, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 15);
            label3.TabIndex = 28;
            label3.Text = "idComision:";
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new System.Drawing.Point(125, 61);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new System.Drawing.Size(100, 23);
            txtIdMateria.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(59, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 26;
            label2.Text = "idMateria:";
            // 
            // txtidEspecialidad
            // 
            txtidEspecialidad.Location = new System.Drawing.Point(125, 23);
            txtidEspecialidad.Name = "txtidEspecialidad";
            txtidEspecialidad.Size = new System.Drawing.Size(100, 23);
            txtidEspecialidad.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 15);
            label1.TabIndex = 24;
            label1.Text = "idEspecialidad:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(12, 165);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(228, 165);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button1_Click;
            // 
            // formEliminarMateriaComision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(315, 200);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdComision);
            Controls.Add(label3);
            Controls.Add(txtIdMateria);
            Controls.Add(label2);
            Controls.Add(txtidEspecialidad);
            Controls.Add(label1);
            Name = "formEliminarMateriaComision";
            Text = "formEliminarMateriaComision";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIdComision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
    }
}