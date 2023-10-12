
namespace Escritorio.Cursado
{
    partial class formModificarCursado
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
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            nupNota = new System.Windows.Forms.NumericUpDown();
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            cbxCurso = new System.Windows.Forms.ComboBox();
            cbxUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)nupNota).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(41, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(41, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(44, 168);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Nota:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new System.Drawing.Point(81, 228);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // nupNota
            // 
            nupNota.Location = new System.Drawing.Point(91, 165);
            nupNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupNota.Name = "nupNota";
            nupNota.Size = new System.Drawing.Size(109, 23);
            nupNota.TabIndex = 5;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new System.Drawing.Point(88, 119);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(112, 23);
            dtpFecha.TabIndex = 6;
            // 
            // cbxCurso
            // 
            cbxCurso.FormattingEnabled = true;
            cbxCurso.Location = new System.Drawing.Point(90, 79);
            cbxCurso.Name = "cbxCurso";
            cbxCurso.Size = new System.Drawing.Size(121, 23);
            cbxCurso.TabIndex = 7;
            cbxCurso.SelectedIndexChanged += cbxCurso_SelectedIndexChanged;
            // 
            // cbxUsuario
            // 
            cbxUsuario.FormattingEnabled = true;
            cbxUsuario.Location = new System.Drawing.Point(91, 36);
            cbxUsuario.Name = "cbxUsuario";
            cbxUsuario.Size = new System.Drawing.Size(121, 23);
            cbxUsuario.TabIndex = 8;
            cbxUsuario.SelectedIndexChanged += cbxUsuario_SelectedIndexChanged;
            cbxUsuario.SelectionChangeCommitted += cbxUsuario_SelectionChangeCommitted;
            // 
            // formModificarCursado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(246, 310);
            Controls.Add(cbxUsuario);
            Controls.Add(cbxCurso);
            Controls.Add(dtpFecha);
            Controls.Add(nupNota);
            Controls.Add(btnModificar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formModificarCursado";
            Text = "formModificarCursado";
            Load += formModificarCursado_Load;
            ((System.ComponentModel.ISupportInitialize)nupNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.NumericUpDown nupNota;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.ComboBox cbxUsuario;
    }
}