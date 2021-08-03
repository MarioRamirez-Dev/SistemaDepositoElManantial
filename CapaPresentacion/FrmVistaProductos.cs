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
    public partial class FrmVistaProductos : Form
    {
        public FrmVistaProductos()
        {
            InitializeComponent();
        }
        //Ocultar Columnas
        private void OcultarColumnas()
        {
            this.dtListado.Columns[0].Visible = false;
            
        }
        //Metodo para mostrar los productos
        private void MostrarProductos()
        {
            this.dtListado.DataSource = NProductos.MostrarProductos();
            this.OcultarColumnas();
            lblTotal.Text = "Total de productos: " + Convert.ToString(dtListado.Rows.Count);
        }
        //Metodo para buscar cliente
        private void BuscarProductosXNombre()
        {
            this.dtListado.DataSource = NProductos.BuscarXProducto(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de productos en la busqueda: " + Convert.ToString(dtListado.Rows.Count);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProductosXNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarProductosXNombre();
        }

        private void FrmVistaProductos_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
        }

        private void dtListado_DoubleClick(object sender, EventArgs e)
        {
            FrmVentas frmVentas = FrmVentas.GetInstancia();
            string id, codigo, nombre;
            decimal precio;
            id = Convert.ToString(this.dtListado.CurrentRow.Cells["Id_Producto"].Value);
            codigo = Convert.ToString(this.dtListado.CurrentRow.Cells["Código"].Value);
            nombre = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre"].Value);
            precio = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["Precio"].Value);
            frmVentas.SetProducto(id,codigo, nombre, precio);

            this.Hide();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }
    }
}
