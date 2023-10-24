
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
            cbxEspecialidades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(378, 136);
            cbxEspecialidades.Margin = new System.Windows.Forms.Padding(4);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(287, 37);
            cbxEspecialidades.TabIndex = 0;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(378, 204);
            cbxPlanes.Margin = new System.Windows.Forms.Padding(4);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(287, 37);
            cbxPlanes.TabIndex = 1;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(233, 139);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 29);
            label1.TabIndex = 2;
            label1.Text = "Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(314, 207);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 29);
            label2.TabIndex = 3;
            label2.Text = "Plan";
            // 
            // txtDescMateria
            // 
            txtDescMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDescMateria.Location = new System.Drawing.Point(378, 279);
            txtDescMateria.Margin = new System.Windows.Forms.Padding(4);
            txtDescMateria.Name = "txtDescMateria";
            txtDescMateria.Size = new System.Drawing.Size(287, 37);
            txtDescMateria.TabIndex = 4;
            txtDescMateria.TextChanged += txtDescMateria_TextChanged;
            // 
            // txtHorasSem
            // 
            txtHorasSem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtHorasSem.Location = new System.Drawing.Point(378, 354);
            txtHorasSem.Margin = new System.Windows.Forms.Padding(4);
            txtHorasSem.Name = "txtHorasSem";
            txtHorasSem.Size = new System.Drawing.Size(188, 37);
            txtHorasSem.TabIndex = 5;
            txtHorasSem.TextChanged += txtHorasSem_TextChanged;
            // 
            // txtHorasTot
            // 
            txtHorasTot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtHorasTot.Location = new System.Drawing.Point(378, 421);
            txtHorasTot.Margin = new System.Windows.Forms.Padding(4);
            txtHorasTot.Name = "txtHorasTot";
            txtHorasTot.Size = new System.Drawing.Size(188, 37);
            txtHorasTot.TabIndex = 6;
            txtHorasTot.TextChanged += txtHorasTot_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(141, 282);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(229, 29);
            label3.TabIndex = 7;
            label3.Text = "Nombre de la materia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(191, 357);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(179, 29);
            label4.TabIndex = 8;
            label4.Text = "Horas semanales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(225, 424);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(145, 29);
            label5.TabIndex = 9;
            label5.Text = "Horas Totales";
            // 
            // btnCrear
            // 
            btnCrear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCrear.Location = new System.Drawing.Point(467, 550);
            btnCrear.Margin = new System.Windows.Forms.Padding(4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(246, 60);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(257, 37);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(352, 35);
            label6.TabIndex = 11;
            label6.Text = "Complete los siguientes datos";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(139, 550);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(246, 60);
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