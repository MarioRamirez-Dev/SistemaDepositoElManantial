using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVistaClientes : Form
    {
        public FrmVistaClientes()
        {
            InitializeComponent();
        }

        private void FrmVistaClientes_Load(object sender, EventArgs e)
        {
            this.MostrarClientes();
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns[0].Visible = false;            
            
        }
        //Metodo para mostrar a los clientes
        private void MostrarClientes()
        {
            this.dtListado.DataSource = NClientes.MostrarClientes();
            this.OcultarColumnas();
            lblTotal.Text = "Total de clientes: " + Convert.ToString(dtListado.Rows.Count);
        }
        //Metodo para buscar cliente
        private void BuscarClienteXNombre()
        {
            this.dtListado.DataSource = NClientes.BuscarClienteXNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de clientes en la busqueda: " + Convert.ToString(dtListado.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarClienteXNombre();
          
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarClienteXNombre();
        }
        //Evento doble click
        private void dtListado_DoubleClick(object sender, EventArgs e)
        {
            FrmVentas frmVentas = FrmVentas.GetInstancia();
            string id, nombres, nit;
            id = Convert.ToString(this.dtListado.CurrentRow.Cells["Codigo"].Value);
            nombres = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombres"].Value)+ " " +Convert.ToString(this.dtListado.CurrentRow.Cells["Apellidos"].Value);
            nit = Convert.ToString(this.dtListado.CurrentRow.Cells["NIT"].Value);
            frmVentas.SetCliente(id, nombres, nit);
            this.Hide();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }
    }
}
