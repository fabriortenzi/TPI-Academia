namespace Escritorio.Evaluacion
{
    partial class formEliminarEvaluacion
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
            txtAnio = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            txtIdMateria = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtLegajo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtIdEvaluacion = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtAnio
            // 
            txtAnio.Location = new System.Drawing.Point(108, 104);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new System.Drawing.Size(100, 23);
            txtAnio.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(61, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(32, 15);
            label4.TabIndex = 34;
            label4.Text = "Año:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(27, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(195, 240);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new System.Drawing.Point(108, 62);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new System.Drawing.Size(100, 23);
            txtIdMateria.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 28;
            label2.Text = "idMateria:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(108, 16);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(100, 23);
            txtLegajo.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(57, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 26;
            label1.Text = "Legajo:";
            // 
            // txtIdEvaluacion
            // 
            txtIdEvaluacion.Location = new System.Drawing.Point(108, 150);
            txtIdEvaluacion.Name = "txtIdEvaluacion";
            txtIdEvaluacion.Size = new System.Drawing.Size(100, 23);
            txtIdEvaluacion.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 153);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 15);
            label3.TabIndex = 38;
            label3.Text = "IdEvaluacion";
            // 
            // formEliminarEvaluacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(291, 290);
            Controls.Add(label3);
            Controls.Add(txtIdEvaluacion);
            Controls.Add(txtAnio);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdMateria);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "formEliminarEvaluacion";
            Text = "formEliminarEvaluacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEvaluacion;
        private System.Windows.Forms.Label label3;
    }
}