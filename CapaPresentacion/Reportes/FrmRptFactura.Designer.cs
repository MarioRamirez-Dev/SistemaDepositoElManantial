namespace CapaPresentacion
{
    partial class FrmRptFactura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptFactura));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Ventas = new CapaPresentacion.Ventas();
            this.SP_Reporte_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_Reporte_FacturaTableAdapter = new CapaPresentacion.VentasTableAdapters.SP_Reporte_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reporte_FacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Ventas";
            reportDataSource1.Value = this.SP_Reporte_FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RptFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Ventas
            // 
            this.Ventas.DataSetName = "Ventas";
            this.Ventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Reporte_FacturaBindingSource
            // 
            this.SP_Reporte_FacturaBindingSource.DataMember = "SP_Reporte_Factura";
            this.SP_Reporte_FacturaBindingSource.DataSource = this.Ventas;
            // 
            // SP_Reporte_FacturaTableAdapter
            // 
            this.SP_Reporte_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRptFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRptFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmRptFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reporte_FacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Reporte_FacturaBindingSource;
        private Ventas Ventas;
        private VentasTableAdapters.SP_Reporte_FacturaTableAdapter SP_Reporte_FacturaTableAdapter;
    }
}