namespace Escritorio
{
    partial class formCrearCurso
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
            label2 = new System.Windows.Forms.Label();
            cbxEspecialidades = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cbxPlanes = new System.Windows.Forms.ComboBox();
            cbxMaterias = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtAño = new System.Windows.Forms.TextBox();
            txtCupo = new System.Windows.Forms.TextBox();
            btnCrear = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(139, 96);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(230, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(212, 165);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(157, 25);
            label2.TabIndex = 1;
            label2.Text = "Seleccione un Plan";
            // 
            // cbxEspecialidades
            // 
            cbxEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidades.FormattingEnabled = true;
            cbxEspecialidades.Location = new System.Drawing.Point(375, 93);
            cbxEspecialidades.Name = "cbxEspecialidades";
            cbxEspecialidades.Size = new System.Drawing.Size(306, 33);
            cbxEspecialidades.TabIndex = 2;
            cbxEspecialidades.SelectedIndexChanged += cbxEspecialidades_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(177, 227);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(192, 25);
            label3.TabIndex = 3;
            label3.Text = "Seleccione una Materia";
            // 
            // cbxPlanes
            // 
            cbxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxPlanes.Enabled = false;
            cbxPlanes.FormattingEnabled = true;
            cbxPlanes.Location = new System.Drawing.Point(375, 162);
            cbxPlanes.Name = "cbxPlanes";
            cbxPlanes.Size = new System.Drawing.Size(306, 33);
            cbxPlanes.TabIndex = 4;
            cbxPlanes.SelectedIndexChanged += cbxPlanes_SelectedIndexChanged;
            // 
            // cbxMaterias
            // 
            cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMaterias.Enabled = false;
            cbxMaterias.FormattingEnabled = true;
            cbxMaterias.Location = new System.Drawing.Point(375, 224);
            cbxMaterias.Name = "cbxMaterias";
            cbxMaterias.Size = new System.Drawing.Size(306, 33);
            cbxMaterias.TabIndex = 5;
            cbxMaterias.SelectedIndexChanged += cbxMaterias_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(292, 36);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(251, 25);
            label4.TabIndex = 6;
            label4.Text = "Complete los siguientes datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(169, 287);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(200, 25);
            label5.TabIndex = 7;
            label5.Text = "Ingrese el año del curso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(159, 341);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(210, 25);
            label6.TabIndex = 8;
            label6.Text = "Ingrese el cupo del curso";
            // 
            // txtAño
            // 
            txtAño.Location = new System.Drawing.Point(375, 284);
            txtAño.Name = "txtAño";
            txtAño.PlaceholderText = "AAAA";
            txtAño.Size = new System.Drawing.Size(143, 31);
            txtAño.TabIndex = 9;
            // 
            // txtCupo
            // 
            txtCupo.Location = new System.Drawing.Point(375, 338);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new System.Drawing.Size(143, 31);
            txtCupo.TabIndex = 10;
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(310, 428);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(257, 56);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += button1_Click;
            // 
            // formCrearCurso
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 517);
            Controls.Add(btnCrear);
            Controls.Add(txtCupo);
            Controls.Add(txtAño);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbxMaterias);
            Controls.Add(cbxPlanes);
            Controls.Add(label3);
            Controls.Add(cbxEspecialidades);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formCrearCurso";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Crear Curso";
            Load += formCrearCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEspecialidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.ComboBox cbxMaterias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Button btnCrear;
    }
}