namespace Escritorio.CRUD.Usuario
{
    partial class updateUsuario
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
            label1 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            dgvUsuario = new System.Windows.Forms.DataGridView();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            txtLegajo = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(210, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(393, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Legajo o Nombre y Apellido del Usuario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(281, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(214, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(167, 138);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(167, 184);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(281, 181);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(214, 31);
            txtApellido.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.Location = new System.Drawing.Point(563, 132);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new System.Drawing.Point(12, 293);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowHeadersWidth = 62;
            dgvUsuario.RowTemplate.Height = 33;
            dgvUsuario.Size = new System.Drawing.Size(776, 225);
            dgvUsuario.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(547, 536);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 34);
            button3.TabIndex = 8;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(676, 536);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(167, 90);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 25);
            label4.TabIndex = 11;
            label4.Text = "Legajo";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(281, 87);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(161, 31);
            txtLegajo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(311, 251);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(184, 25);
            label5.TabIndex = 12;
            label5.Text = "Seleccione un Usuario";
            // 
            // updateUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 579);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLegajo);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dgvUsuario);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "updateUsuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Modificar Usuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label5;
    }
}