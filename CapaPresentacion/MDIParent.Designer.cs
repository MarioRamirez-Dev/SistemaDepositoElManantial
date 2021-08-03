namespace CapaPresentacion
{
    partial class MDIParent
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.depósitoElManantialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMantenimientoProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depósitoElManantialToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(737, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // depósitoElManantialToolStripMenuItem
            // 
            this.depósitoElManantialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.depósitoElManantialToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.logoDep;
            this.depósitoElManantialToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.depósitoElManantialToolStripMenuItem.Name = "depósitoElManantialToolStripMenuItem";
            this.depósitoElManantialToolStripMenuItem.Size = new System.Drawing.Size(167, 21);
            this.depósitoElManantialToolStripMenuItem.Text = "Depósito el Manantial";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.abort_146072_960_720;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimientoProductos});
            this.productosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.productos;
            this.productosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // mnuMantenimientoProductos
            // 
            this.mnuMantenimientoProductos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mnuMantenimientoProductos.Name = "mnuMantenimientoProductos";
            this.mnuMantenimientoProductos.Size = new System.Drawing.Size(249, 22);
            this.mnuMantenimientoProductos.Text = "Mantenimiento de Productos";
            this.mnuMantenimientoProductos.Click += new System.EventHandler(this.mnuMantenimientoProductos_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.ventas;
            this.ventasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            this.registroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.registroDeVentasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.clientes;
            this.clientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // mantenimientoDeClientesToolStripMenuItem
            // 
            this.mantenimientoDeClientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mantenimientoDeClientesToolStripMenuItem.Name = "mantenimientoDeClientesToolStripMenuItem";
            this.mantenimientoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.mantenimientoDeClientesToolStripMenuItem.Text = "Mantenimiento de Clientes";
            this.mantenimientoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeClientesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDelDiaToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Reportes;
            this.reportesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDelDiaToolStripMenuItem
            // 
            this.reporteDelDiaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.reporteDelDiaToolStripMenuItem.Name = "reporteDelDiaToolStripMenuItem";
            this.reporteDelDiaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reporteDelDiaToolStripMenuItem.Text = "Reporte por Fecha";
            this.reporteDelDiaToolStripMenuItem.Click += new System.EventHandler(this.reporteDelDiaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 536);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(737, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(166, 17);
            this.toolStripStatusLabel.Text = "Sistema Depósito el Manantial";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(597, 4);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 16);
            this.lblHora.TabIndex = 6;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.PanelContenedor.BackgroundImage = global::CapaPresentacion.Properties.Resources.Deposito_Fondo_def;
            this.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 25);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(737, 511);
            this.PanelContenedor.TabIndex = 4;
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 558);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Prinicpal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent_FormClosing);
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem depósitoElManantialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDelDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimientoProductos;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Timer timer1;
       
        private System.Windows.Forms.Label lblHora;
    }
}



