using Microsoft.VisualBasic.Logging;
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
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormInPanel(Form frm)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            else
            {
                frm.TopLevel = false;
                this.PanelContenedor.Controls.Add(frm);
                this.PanelContenedor.Tag = frm;
                frm.Show();
            }
        }

        private void mnuMantenimientoProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.MdiParent = this;
            AbrirFormInPanel(frm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frm = FrmVentas.GetInstancia();
            frm.MdiParent = this;
            AbrirFormInPanel(frm);
        }

        private void mantenimientoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.MdiParent = this;
            AbrirFormInPanel(frm);
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reporteDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePorFechas frm = new FrmReportePorFechas();
            frm.MdiParent = this;
            AbrirFormInPanel(frm);
        }

        

        

        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}