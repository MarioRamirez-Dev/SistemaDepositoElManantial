using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRptFactura : Form
    {
        public FrmRptFactura()
        {
            InitializeComponent();
        }
        private int idventa;
        public int Idventa { get => idventa; set => idventa = value; }

        private void FrmRptFactura_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'Ventas.SP_Reporte_Factura' Puede moverla o quitarla según sea necesario.
                this.SP_Reporte_FacturaTableAdapter.Fill(this.Ventas.SP_Reporte_Factura, Idventa);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
