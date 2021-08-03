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
    public partial class FrmReportePorFechas : Form
    {
        public FrmReportePorFechas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmRptRangoFechas frm = new FrmRptRangoFechas();
            frm.Fecha1 = dtpFecha1.Value;
            frm.Fecha2 = dtpFecha2.Value;
            frm.ShowDialog();
        }
    }
}
