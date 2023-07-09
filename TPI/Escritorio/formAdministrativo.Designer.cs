namespace Escritorio
{
    partial class formAdministrativo
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
            mnsPrincipal = new System.Windows.Forms.MenuStrip();
            usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            consultarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnsPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnsPrincipal
            // 
            mnsPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { usuarioToolStripMenuItem });
            mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            mnsPrincipal.Name = "mnsPrincipal";
            mnsPrincipal.Size = new System.Drawing.Size(912, 33);
            mnsPrincipal.TabIndex = 1;
            mnsPrincipal.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { crearUsuarioToolStripMenuItem, consultarUsuarioToolStripMenuItem, modificarUsuarioToolStripMenuItem, eliminarUsuarioToolStripMenuItem, salirDelSistemaToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            crearUsuarioToolStripMenuItem.Click += crearUsuarioToolStripMenuItem_Click;
            // 
            // consultarUsuarioToolStripMenuItem
            // 
            consultarUsuarioToolStripMenuItem.Name = "consultarUsuarioToolStripMenuItem";
            consultarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            consultarUsuarioToolStripMenuItem.Text = "Consultar Usuario";
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            // 
            // formAdministrativo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(912, 529);
            Controls.Add(mnsPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = mnsPrincipal;
            Name = "formAdministrativo";
            Text = "Menu Administrativo";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosed += formAdministrativo_FormClosed;
            mnsPrincipal.ResumeLayout(false);
            mnsPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}