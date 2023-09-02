
namespace Escritorio.MateriaComision
{
    partial class formModificarMateriaComision
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDS = new System.Windows.Forms.NumericUpDown();
            this.nudCupo = new System.Windows.Forms.NumericUpDown();
            this.mtbHora_fin = new System.Windows.Forms.MaskedTextBox();
            this.mtbHora_ini = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Comision:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Materia:";
            // 
            // nudDS
            // 
            this.nudDS.Location = new System.Drawing.Point(346, 62);
            this.nudDS.Name = "nudDS";
            this.nudDS.Size = new System.Drawing.Size(35, 23);
            this.nudDS.TabIndex = 47;
            // 
            // nudCupo
            // 
            this.nudCupo.Location = new System.Drawing.Point(346, 27);
            this.nudCupo.Name = "nudCupo";
            this.nudCupo.Size = new System.Drawing.Size(35, 23);
            this.nudCupo.TabIndex = 46;
            // 
            // mtbHora_fin
            // 
            this.mtbHora_fin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbHora_fin.Location = new System.Drawing.Point(346, 131);
            this.mtbHora_fin.Mask = "00:00";
            this.mtbHora_fin.Name = "mtbHora_fin";
            this.mtbHora_fin.Size = new System.Drawing.Size(35, 23);
            this.mtbHora_fin.TabIndex = 45;
            this.mtbHora_fin.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHora_ini
            // 
            this.mtbHora_ini.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbHora_ini.Location = new System.Drawing.Point(346, 97);
            this.mtbHora_ini.Mask = "00:00";
            this.mtbHora_ini.Name = "mtbHora_ini";
            this.mtbHora_ini.Size = new System.Drawing.Size(35, 23);
            this.mtbHora_ini.TabIndex = 44;
            this.mtbHora_ini.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Hora de fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Hora de inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Dia de la semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cupo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(37, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(331, 231);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(94, 105);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(71, 15);
            this.lblComision.TabIndex = 53;
            this.lblComision.Text = "lblComision";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(94, 55);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(60, 15);
            this.lblMateria.TabIndex = 52;
            this.lblMateria.Text = "lblMateria";
            // 
            // formModificarMateriaComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 281);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDS);
            this.Controls.Add(this.nudCupo);
            this.Controls.Add(this.mtbHora_fin);
            this.Controls.Add(this.mtbHora_ini);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Name = "formModificarMateriaComision";
            this.Text = "formModificarMateriaComision";
            ((System.ComponentModel.ISupportInitialize)(this.nudDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDS;
        private System.Windows.Forms.NumericUpDown nudCupo;
        private System.Windows.Forms.MaskedTextBox mtbHora_fin;
        private System.Windows.Forms.MaskedTextBox mtbHora_ini;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblMateria;
    }
}