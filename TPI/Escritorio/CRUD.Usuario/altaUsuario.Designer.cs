namespace Escritorio.CRUD.Alumno
{
    partial class altaUsuario
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
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblLegajo = new System.Windows.Forms.Label();
            lblDNI = new System.Windows.Forms.Label();
            lblNomUsuario = new System.Windows.Forms.Label();
            lblContraseña = new System.Windows.Forms.Label();
            lblConfContr = new System.Windows.Forms.Label();
            btnCrear = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            txtLegajo = new System.Windows.Forms.TextBox();
            txtDNI = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            txtNomUsuario = new System.Windows.Forms.TextBox();
            txtContraseña = new System.Windows.Forms.TextBox();
            txtConfContr = new System.Windows.Forms.TextBox();
            rdioAlumno = new System.Windows.Forms.RadioButton();
            rdioProfesor = new System.Windows.Forms.RadioButton();
            rdioAdmin = new System.Windows.Forms.RadioButton();
            label9 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(192, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(251, 25);
            label1.TabIndex = 0;
            label1.Text = "Complete los siguientes datos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(172, 261);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(172, 312);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(78, 25);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            lblApellido.Visible = false;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new System.Drawing.Point(186, 162);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new System.Drawing.Size(64, 25);
            lblLegajo.TabIndex = 3;
            lblLegajo.Text = "Legajo";
            lblLegajo.Visible = false;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new System.Drawing.Point(207, 212);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new System.Drawing.Size(43, 25);
            lblDNI.TabIndex = 4;
            lblDNI.Text = "DNI";
            lblDNI.Visible = false;
            // 
            // lblNomUsuario
            // 
            lblNomUsuario.AutoSize = true;
            lblNomUsuario.Location = new System.Drawing.Point(82, 360);
            lblNomUsuario.Name = "lblNomUsuario";
            lblNomUsuario.Size = new System.Drawing.Size(168, 25);
            lblNomUsuario.TabIndex = 5;
            lblNomUsuario.Text = "Nombre de Usuario";
            lblNomUsuario.Visible = false;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new System.Drawing.Point(149, 411);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new System.Drawing.Size(101, 25);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Visible = false;
            // 
            // lblConfContr
            // 
            lblConfContr.AutoSize = true;
            lblConfContr.Location = new System.Drawing.Point(65, 459);
            lblConfContr.Name = "lblConfContr";
            lblConfContr.Size = new System.Drawing.Size(185, 25);
            lblConfContr.TabIndex = 7;
            lblConfContr.Text = "Confirmar Contraseña";
            lblConfContr.Visible = false;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCrear.Location = new System.Drawing.Point(335, 553);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(171, 34);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear Usuario";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancelar.Location = new System.Drawing.Point(130, 553);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(159, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(273, 159);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(129, 31);
            txtLegajo.TabIndex = 10;
            txtLegajo.Visible = false;
            // 
            // txtDNI
            // 
            txtDNI.Location = new System.Drawing.Point(273, 209);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(209, 31);
            txtDNI.TabIndex = 11;
            txtDNI.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(273, 258);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(209, 31);
            txtNombre.TabIndex = 12;
            txtNombre.Visible = false;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(273, 309);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(209, 31);
            txtApellido.TabIndex = 13;
            txtApellido.Visible = false;
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.Location = new System.Drawing.Point(273, 357);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new System.Drawing.Size(209, 31);
            txtNomUsuario.TabIndex = 14;
            txtNomUsuario.Visible = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new System.Drawing.Point(273, 408);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new System.Drawing.Size(209, 31);
            txtContraseña.TabIndex = 15;
            txtContraseña.Visible = false;
            // 
            // txtConfContr
            // 
            txtConfContr.Location = new System.Drawing.Point(273, 456);
            txtConfContr.Name = "txtConfContr";
            txtConfContr.Size = new System.Drawing.Size(209, 31);
            txtConfContr.TabIndex = 16;
            txtConfContr.Visible = false;
            // 
            // rdioAlumno
            // 
            rdioAlumno.AutoSize = true;
            rdioAlumno.Location = new System.Drawing.Point(214, 104);
            rdioAlumno.Name = "rdioAlumno";
            rdioAlumno.Size = new System.Drawing.Size(100, 29);
            rdioAlumno.TabIndex = 17;
            rdioAlumno.TabStop = true;
            rdioAlumno.Text = "Alumno";
            rdioAlumno.UseVisualStyleBackColor = true;
            rdioAlumno.CheckedChanged += rdioAlumno_CheckedChanged;
            // 
            // rdioProfesor
            // 
            rdioProfesor.AutoSize = true;
            rdioProfesor.Location = new System.Drawing.Point(326, 104);
            rdioProfesor.Name = "rdioProfesor";
            rdioProfesor.Size = new System.Drawing.Size(104, 29);
            rdioProfesor.TabIndex = 18;
            rdioProfesor.TabStop = true;
            rdioProfesor.Text = "Profesor";
            rdioProfesor.UseVisualStyleBackColor = true;
            rdioProfesor.CheckedChanged += rdioProfesor_CheckedChanged;
            // 
            // rdioAdmin
            // 
            rdioAdmin.AutoSize = true;
            rdioAdmin.Location = new System.Drawing.Point(446, 104);
            rdioAdmin.Name = "rdioAdmin";
            rdioAdmin.Size = new System.Drawing.Size(153, 29);
            rdioAdmin.TabIndex = 19;
            rdioAdmin.TabStop = true;
            rdioAdmin.Text = "Administrativo";
            rdioAdmin.UseVisualStyleBackColor = true;
            rdioAdmin.CheckedChanged += rdioAdmin_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(42, 106);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(137, 25);
            label9.TabIndex = 20;
            label9.Text = "Tipo de Usuario";
            // 
            // altaUsuario
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(634, 622);
            Controls.Add(label9);
            Controls.Add(rdioAdmin);
            Controls.Add(rdioProfesor);
            Controls.Add(rdioAlumno);
            Controls.Add(txtConfContr);
            Controls.Add(txtContraseña);
            Controls.Add(txtNomUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(txtLegajo);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(lblConfContr);
            Controls.Add(lblContraseña);
            Controls.Add(lblNomUsuario);
            Controls.Add(lblDNI);
            Controls.Add(lblLegajo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "altaUsuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Crear Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblConfContr;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtConfContr;
        private System.Windows.Forms.RadioButton rdioAlumno;
        private System.Windows.Forms.RadioButton rdioProfesor;
        private System.Windows.Forms.RadioButton rdioAdmin;
        private System.Windows.Forms.Label label9;
    }
}