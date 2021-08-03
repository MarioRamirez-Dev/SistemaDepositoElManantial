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
    public partial class FrmProductos : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmProductos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCodigo, "Ingrese el codigo del producto");
            this.ttMensaje.SetToolTip(this.txtNombreProd, "Ingrese el nombre del producto");
            this.ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese una desripcion del producto si desea.");
            this.ttMensaje.SetToolTip(this.txtPrecio, "Registre el precio unitario del articulo");
            this.ttMensaje.SetToolTip(this.txtBuscar, "Ingrese el nombre del cliente que desea buscar");
            this.txtID.Visible = false;
            this.lblID.Visible = false;

        }
        //Metodos Vacios
        private void groupBox1_Enter(object sender, EventArgs e){}
        //LOAD
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.HabilitarBotones();
            this.HabilitarTxt(false);
            this.MostrarProductos();
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
        //Metodo para limpiar las cajas de texto
        private void Limpiar()
        {
            this.txtID.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtNombreProd.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.txtBuscar.Text = string.Empty;
        }
        //Metodo para habilitar las cajas de texto
        private void HabilitarTxt(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombreProd.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtPrecio.ReadOnly = !valor;
        }
        //Metodo para Habilitar los botones
        private void HabilitarBotones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.HabilitarTxt(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.HabilitarTxt(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        //Metodo para mostrar los productos
        private void MostrarProductos()
        {
            this.dtListado.DataSource = NProductos.MostrarProductos();
            lblTotal.Text = "Total de productos: " + Convert.ToString(dtListado.Rows.Count);
        }
        //Metodo para buscar productos
        private void BuscarProductosXNombre()
        {
            this.dtListado.DataSource = NProductos.BuscarXProducto(this.txtBuscar.Text);
            lblTotal.Text = "Total de productos en la busqueda: " + Convert.ToString(dtListado.Rows.Count);
        }
                   
        //BOTON NUEVO
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.HabilitarTxt(true);
            this.HabilitarBotones();
            this.txtCodigo.Focus();
            this.txtID.Visible = false;
            this.lblID.Visible = false;
        }
        //BOTON GUARDAR
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtCodigo.Text == string.Empty || this.txtNombreProd.Text == string.Empty ||
                   this.txtPrecio.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, los cuales serán marcados.");
                    erroricono.SetError(txtCodigo, "Ingrese el codigo del producto.");
                    erroricono.SetError(txtNombreProd, "Ingrese el nombre del producto.");
                    erroricono.SetError(txtPrecio, "Ingrese el precio unitario del producto.");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NProductos.InsertarProducto
                       (this.txtCodigo.Text.ToUpper(),
                        this.txtNombreProd.Text.ToUpper(),
                        this.txtDescripcion.Text.ToUpper(),
                        Convert.ToDecimal(this.txtPrecio.Text));
                    }
                    else
                    {
                        rpta = NProductos.EditarProductos
                       (Convert.ToInt32(this.txtID.Text),
                        this.txtCodigo.Text.ToUpper(),
                        this.txtNombreProd.Text.ToUpper(),
                        this.txtDescripcion.Text.ToUpper(),
                        Convert.ToDecimal(this.txtPrecio.Text));
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se guardo satisfactoriamente el producto");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizaron satisfactoriamente los datos del producto");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.HabilitarBotones();
                    this.MostrarProductos();
                    this.Limpiar();
                    this.txtID.Visible = false;
                    this.lblID.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
                                
        }

        //BOTON EDITAR
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!this.txtID.Text.Equals(""))
            {
                this.txtNombreProd.Focus();
                this.IsNuevo = false;
                this.IsEditar = true;
                this.HabilitarBotones();
                this.HabilitarTxt(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar previamente un cliente en el listado de abajo.");
            }

        }
        //BOTON CANCELAR
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.HabilitarTxt(false);
            this.Limpiar();
            this.txtID.Visible = false;
            this.lblID.Visible = false;
        }
        //Metodo al dar doble click, que se llenen los campos de texto
        private void dtListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[0].Value);
            this.txtNombreProd.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[2].Value);
            this.txtCodigo.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[1].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[3].Value);
            this.txtPrecio.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[4].Value);

            this.txtID.Visible = true;
            this.txtID.ReadOnly = true;
            this.lblID.Visible = true;
        }
        //Metodo para busqueda dinamica
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarProductosXNombre();
        }
        //BOTON BUSCAR PRODUCTO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProductosXNombre();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }
    }
    
}

