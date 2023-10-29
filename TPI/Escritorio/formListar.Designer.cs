
namespace Escritorio.Generalizado
{
    partial class formListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formListar));
            panel1 = new System.Windows.Forms.Panel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            lblClase = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            txtConsulta = new System.Windows.Forms.ToolStripTextBox();
            btnBuscar = new System.Windows.Forms.ToolStripButton();
            BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            dgvGrilla = new System.Windows.Forms.DataGridView();
            btnListar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnConsultar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(632, 34);
            panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblClase, toolStripSeparator1, txtConsulta, btnBuscar });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(632, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // lblClase
            // 
            lblClase.Name = "lblClase";
            lblClase.Size = new System.Drawing.Size(48, 31);
            lblClase.Text = "lblClase";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 125, 0);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // txtConsulta
            // 
            txtConsulta.Margin = new System.Windows.Forms.Padding(1, 0, 15, 0);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new System.Drawing.Size(250, 34);
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnBuscar.Image = (System.Drawing.Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(46, 31);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // dgvGrilla
            // 
            dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvGrilla.Location = new System.Drawing.Point(0, 34);
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.Size = new System.Drawing.Size(632, 220);
            dgvGrilla.TabIndex = 1;
            // 
            // btnListar
            // 
            btnListar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnListar.Location = new System.Drawing.Point(50, 3);
            btnListar.Margin = new System.Windows.Forms.Padding(50, 3, 36, 3);
            btnListar.Name = "btnListar";
            btnListar.Size = new System.Drawing.Size(75, 30);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAgregar.Location = new System.Drawing.Point(164, 3);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 3, 36, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 30);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEliminar.Location = new System.Drawing.Point(278, 3);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 3, 36, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 30);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnModificar.Location = new System.Drawing.Point(392, 3);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 3, 36, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(75, 30);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            flowLayoutPanel1.Controls.Add(btnListar);
            flowLayoutPanel1.Controls.Add(btnAgregar);
            flowLayoutPanel1.Controls.Add(btnEliminar);
            flowLayoutPanel1.Controls.Add(btnModificar);
            flowLayoutPanel1.Controls.Add(btnConsultar);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(632, 40);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnConsultar.Location = new System.Drawing.Point(506, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(75, 30);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Left;
            button1.Location = new System.Drawing.Point(3, 76);
            button1.Margin = new System.Windows.Forms.Padding(3, 40, 30, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 0);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 254);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(632, 43);
            panel2.TabIndex = 7;
            // 
            // formListar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            ClientSize = new System.Drawing.Size(632, 297);
            Controls.Add(dgvGrilla);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "formListar";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "formListar";
            Load += formListar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblClase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtConsulta;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConsultar;
    }
}