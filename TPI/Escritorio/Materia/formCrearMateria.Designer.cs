
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
            cbxEspecialidades = new System.Windows.Forms.ComboBox();
            cbxPlanes = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtDescMateria = new System.Windows.Forms.TextBox();
            txtHorasSem = new System.Windows.Forms.TextBox();
            txtHorasTot = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnCrear = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(378, 136);
            cbxEspecialidades.Margin = new System.Windows.Forms.Padding(4);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(287, 33);
            cbxEspecialidades.TabIndex = 0;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(378, 204);
            cbxPlanes.Margin = new System.Windows.Forms.Padding(4);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(287, 33);
            cbxPlanes.TabIndex = 1;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(164, 138);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 25);
            label1.TabIndex = 2;
            label1.Text = "Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(164, 207);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 25);
            label2.TabIndex = 3;
            label2.Text = "Plan";
            // 
            // txtDescMateria
            // 
            txtDescMateria.Location = new System.Drawing.Point(378, 284);
            txtDescMateria.Margin = new System.Windows.Forms.Padding(4);
            txtDescMateria.Name = "txtDescMateria";
            txtDescMateria.Size = new System.Drawing.Size(287, 31);
            txtDescMateria.TabIndex = 4;
            txtDescMateria.TextChanged += txtDescMateria_TextChanged;
            // 
            // txtHorasSem
            // 
            txtHorasSem.Location = new System.Drawing.Point(378, 360);
            txtHorasSem.Margin = new System.Windows.Forms.Padding(4);
            txtHorasSem.Name = "txtHorasSem";
            txtHorasSem.Size = new System.Drawing.Size(188, 31);
            txtHorasSem.TabIndex = 5;
            txtHorasSem.TextChanged += txtHorasSem_TextChanged;
            // 
            // txtHorasTot
            // 
            txtHorasTot.Location = new System.Drawing.Point(378, 438);
            txtHorasTot.Margin = new System.Windows.Forms.Padding(4);
            txtHorasTot.Name = "txtHorasTot";
            txtHorasTot.Size = new System.Drawing.Size(188, 31);
            txtHorasTot.TabIndex = 6;
            txtHorasTot.TextChanged += txtHorasTot_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(164, 286);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(185, 25);
            label3.TabIndex = 7;
            label3.Text = "Nombre de la materia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(164, 362);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(146, 25);
            label4.TabIndex = 8;
            label4.Text = "Horas semanales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(164, 439);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 25);
            label5.TabIndex = 9;
            label5.Text = "Horas Totales";
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(467, 540);
            btnCrear.Margin = new System.Windows.Forms.Padding(4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(246, 70);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(296, 34);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(251, 25);
            label6.TabIndex = 11;
            label6.Text = "Complete los siguientes datos";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(139, 540);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(246, 70);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formCrearMateria
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(852, 647);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(btnCrear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtHorasTot);
            Controls.Add(txtHorasSem);
            Controls.Add(txtDescMateria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxPlanes);
            Controls.Add(cbxEspecialidades);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "formCrearMateria";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Crear Materia";
            Load += formCrearMateria_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
    }
}