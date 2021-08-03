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
    public partial class FrmRptRangoFechas : Form
    {
        public FrmRptRangoFechas()
        {
            InitializeComponent();
        }
        private DateTime fecha1;
        private DateTime fecha2;

        public DateTime Fecha1 { get => fecha1; set => fecha1 = value; }
        public DateTime Fecha2 { get => fecha2; set => fecha2 = value; }

        private void FrmRptRangoFechas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'Ventas.SP_Buscar_Venta_Fechas' Puede moverla o quitarla según sea necesario.
                this.SP_Buscar_Venta_FechasTableAdapter.Fill(this.Ventas.SP_Buscar_Venta_Fechas, Fecha1, Fecha2);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
