
namespace Escritorio.Comision
{
    partial class formEliminarComision
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
            cbxEspecialidad = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnCrear = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            cbxComision = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // cbxEspecialidad
            // 
            cbxEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEspecialidad.FormattingEnabled = true;
            cbxEspecialidad.Location = new System.Drawing.Point(158, 54);
            cbxEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            cbxEspecialidad.Name = "cbxEspecialidad";
            cbxEspecialidad.Size = new System.Drawing.Size(199, 23);
            cbxEspecialidad.TabIndex = 7;
            cbxEspecialidad.SelectedIndexChanged += cbxEspecialidad_SelectedIndexChanged;
            cbxEspecialidad.StyleChanged += cbxEspecialidad_StyleChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(158, 16);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 15);
            label1.TabIndex = 8;
            label1.Text = "Complete los siguientes datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(73, 60);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 15);
            label2.TabIndex = 9;
            label2.Text = "Especialidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(87, 89);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 15);
            label3.TabIndex = 10;
            label3.Text = "Comision:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(259, 137);
            btnCrear.Margin = new System.Windows.Forms.Padding(2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(161, 38);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Borrar";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(73, 137);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(161, 38);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbxComision
            // 
            cbxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxComision.Enabled = false;
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new System.Drawing.Point(158, 86);
            cbxComision.Margin = new System.Windows.Forms.Padding(2);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new System.Drawing.Size(199, 23);
            cbxComision.TabIndex = 13;
            cbxComision.SelectedIndexChanged += cbxComision_SelectedIndexChanged;
            cbxComision.SelectionChangeCommitted += cbxComision_SelectionChangeCommitted;
            // 
            // formEliminarComision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(485, 191);
            Controls.Add(cbxComision);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxEspecialidad);
            Name = "formEliminarComision";
            Text = "formEliminarComision";
            Load += formEliminarComision_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxComision;
    }
}