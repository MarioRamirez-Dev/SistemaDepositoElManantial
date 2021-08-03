using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVentas : Form
    {
        //Variables 
        private bool IsNuevo = false;
        private DataTable dtDetalle;
        private Decimal totalPagado = 0;
        private static FrmVentas Instancia;
        //Instancia
        public static FrmVentas GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new FrmVentas();
            }
            return Instancia;
        }
        //Metodos para extraer los datos de otro formulario
        public void SetCliente(string idcliente, string nombre, string nit)
        {
            this.txtIdCliente.Text = idcliente;
            this.txtNombres.Text = nombre;
            this.txtNIT.Text = nit;
        }
        public void SetProducto(string idproducto, string codigo,  string producto, Decimal precio)
        {
            this.txtIdProducto.Text = idproducto;
            this.txtCodigo.Text = codigo;
            this.txtProducto.Text = producto;
            this.txtPrecio.Text = Convert.ToString(precio);
        }
        //Evento para cerrar la instancia
        private void FrmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instancia = null;
        }
        //Constructor
        public FrmVentas()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombres, "Seleccione un cliente.");
            this.ttMensaje.SetToolTip(this.txtNIT, "Acá se muestra el NIT del cliente.");
            this.ttMensaje.SetToolTip(this.txtProducto, "Seleccione un producto existente.");
            this.ttMensaje.SetToolTip(this.txtPrecio, "Puede cambiar el precio del producto.");
            this.ttMensaje.SetToolTip(this.txtCantidad, "Ingrese la cantidad de productos que venderá.");
            this.lblIDVenta.Visible = false;
            this.txtIdVenta.Visible = false;
            this.txtCodigo.Visible = false;
            this.txtIdProducto.Visible = false;
            this.txtIdCliente.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmbOpciones.Enabled = false;
        }
        //Evento Load
        private void FrmVentas_Load(object sender, EventArgs e)
        {                    
            this.HabilitarBotones();
            this.HabilitarTxt(false);
            this.MostrarVentas();
            this.CrearTabla();
        }

        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Deposito el Manantial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Deposito el Manantial", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Metodos para limpiar las cajas de texto
        private void Limpiar()
        {
            this.txtIdVenta.Text = string.Empty;
            this.txtNombres.Text = string.Empty;
            this.txtNIT.Text = string.Empty;
            this.lblTotal_Pagar.Text = "0.00";
            this.txtDescuento.Text = "0.00";
            totalPagado = 0;
            this.CrearTabla();
        }
        private void LimpiarDetalle()
        {
            this.txtIdProducto.Text = string.Empty;
            this.txtProducto.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;           
        }
        //Metodo para habilitar las cajas de texto
        private void HabilitarTxt(bool valor)
        {
            this.txtIdVenta.ReadOnly = !valor;
            this.txtIdCliente.ReadOnly = !valor;
            this.txtNombres.ReadOnly = !valor;
            this.txtNIT.ReadOnly = !valor;
            this.btnBuscarCliente.Enabled = valor;
            this.txtIdProducto.ReadOnly = !valor;
            this.txtProducto.ReadOnly = !valor;
            this.txtPrecio.ReadOnly = !valor;
            this.btnBuscarProductos.Enabled = valor;
            this.txtCantidad.ReadOnly = !valor;
            this.txtDescuento.ReadOnly = !valor;
            this.btnAgregar.Enabled = valor;
            this.btnQuitar.Enabled = valor;
        }
        //Metodo para Habilitar los botones
        private void HabilitarBotones()
        {
            if (this.IsNuevo)
            {
                this.HabilitarTxt(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.HabilitarTxt(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }
         
        private void MostrarVentas()
        {
            this.dtListado.DataSource = NVentas.MostrarVentas();
            
            this.lblTotal.Visible = false;
        }
        //Metodo buscar entre fechas
        private void BuscarFechas()
        {
            this.dtListado.DataSource = NVentas.BuscarFechas(this.dtpFecha1.Value, this.dtpFecha2.Value);            
            
            this.lblTotal.Visible = true;
            
        }
        //Mostrar Detalle
        private void MostrarDetalle()
        {
            this.dataDetalle.DataSource = NVentas.MostrarDetalles(Convert.ToInt32(this.txtIdVenta.Text));
         
        }
        //Metodo Crear Tabla para los detalles
        private void CrearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("Id_Producto", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Código", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Producto",  System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad_Productos", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Precio_Venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"));
           

            /*Relacionar Tabla con Tabla*/
            this.dataDetalle.DataSource = this.dtDetalle;
           
        }
       //Boton Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.HabilitarBotones();
            this.Limpiar();
            this.HabilitarTxt(true);
            this.btnBuscarCliente.Focus();
            this.LimpiarDetalle();
        }
        //Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.HabilitarBotones();
            this.HabilitarTxt(false);
            this.Limpiar();
            this.LimpiarDetalle();
        }
        //Boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombres.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, los cuales serán marcados.");
                    erroricono.SetError(txtNombres, "Ingrese un cliente.");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NVentas.InsertarVenta
                                        (Convert.ToInt32(this.txtIdCliente.Text),
                                         Convert.ToDateTime(DateTime.Now.ToLongDateString()),
                                         Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")),
                                         dtDetalle);
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se guardo satisfactoriamente la venta");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.HabilitarBotones();
                    this.LimpiarDetalle();
                    this.Limpiar();
                    this.MostrarVentas();
                    this.txtIdCliente.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Boton para agregar una venta
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombres.Text == string.Empty || this.txtProducto.Text == string.Empty||this.txtCantidad.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, los cuales serán marcados.");
                    erroricono.SetError(txtNombres, "Ingrese un cliente.");
                    erroricono.SetError(txtProducto, "Busque un producto.");
                    erroricono.SetError(txtCantidad, "Ingrese la cantidad de productos a vender");
                }
                else
                {
                    bool registrar = true;

                    /*foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["Id_Producto"]) == Convert.ToInt32(this.txtIdProducto.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya se encuentra el articulo");
                        }
                    }*/

                    if (registrar)
                    {
                        Decimal Descuento = Convert.ToDecimal(this.txtDescuento.Text);
                        Decimal SubTotal = Convert.ToDecimal(this.txtPrecio.Text) * Convert.ToDecimal(this.txtCantidad.Text) - Descuento;
                        totalPagado = (totalPagado + SubTotal);
                        this.lblTotal_Pagar.Text = totalPagado.ToString("#0.00#");


                        //Agregar los detalles
                        DataRow row = this.dtDetalle.NewRow();
                        row["Id_Producto"] = Convert.ToInt32(this.txtIdProducto.Text);
                        row["Código"] = Convert.ToString(this.txtCodigo.Text);
                        row["Producto"] = Convert.ToString(this.txtProducto.Text);
                        row["Cantidad_Productos"] = Convert.ToInt32(this.txtCantidad.Text);
                        row["Precio_Venta"] = Convert.ToDecimal(this.txtPrecio.Text);
                        row["Descuento"] = Convert.ToDecimal(this.txtDescuento.Text);
                        row["SubTotal"] = Convert.ToDecimal(SubTotal);

                        this.dtDetalle.Rows.Add(row);
                        this.LimpiarDetalle();

                    }
                    else
                    {
                        MensajeError("Revise bien los datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                    int indiceFila = this.dataDetalle.CurrentCell.RowIndex;
                   DataRow row = this.dtDetalle.Rows[indiceFila];
                    //Disminuir el total
                    this.totalPagado = this.totalPagado - Convert.ToDecimal(row["SubTotal"].ToString());
                    this.lblTotal_Pagar.Text = totalPagado.ToString("#0.00#");
                    //Remover la fila
                    this.dtDetalle.Rows.Remove(row);
                
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }
        //Boton para buscar al cliente
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVistaClientes vistaClientes = new FrmVistaClientes();
            vistaClientes.ShowDialog();
        }
        //Boton para buscar el producto
        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            FrmVistaProductos vistaProductos = new FrmVistaProductos();
            vistaProductos.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbOpciones.Text.Equals("Fecha:")) 
            {
                this.BuscarFechas();
                lblTotal.Text = "Total de ventas: " +  Convert.ToString(dtListado.Rows.Count);

            }
            else if (cmbOpciones.Text.Equals("Cliente:"))
            {
               
            }
        }

        private void dtListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdVenta.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Id_Venta"].Value);
            this.txtIdCliente.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Id_Cliente"].Value);
            this.txtNombres.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Cliente"].Value);         
            this.lblTotal_Pagar.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Total"].Value);
            this.MostrarDetalle();            

            this.tabControl1.SelectedIndex = 0;

        }
        //Mostrar la hora en tiempo real
        private void tmr1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }
        //Evento al momento de establecer el tipo de busqueda en combobox
        private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpciones.Text.Equals("Fecha:"))
            {
                this.txtBuscar.Visible = false;
                this.dtpFecha1.Visible = true;
                this.dtpFecha2.Visible = true;
            }
            else if (cmbOpciones.Text.Equals("Cliente:"))
            {
                this.dtpFecha1.Visible = false;
                this.dtpFecha2.Visible = false;
                this.txtBuscar.Visible = true;
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            this.MostrarVentas();
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            try
            {
                FrmRptFactura factura = new FrmRptFactura();
                factura.Idventa = Convert.ToInt32(this.dtListado.CurrentRow.Cells["Id_Venta"].Value);
                factura.ShowDialog();
            }
            catch (Exception ex)
            {
                MensajeError("ERROR con código 486, Porfavor verifique que ha seleccionado una venta.");
            }
            
        }
    }
}
