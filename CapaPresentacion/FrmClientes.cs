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
    public partial class FrmClientes : Form
    {
        //Variables Principales
        private bool IsNuevo = false;
        private bool IsEditar= false;
        public FrmClientes()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombres, "Ingrese los nombres del cliente");
            this.ttMensaje.SetToolTip(this.txtApellidos, "Ingrese los apellidos del cliente");
            this.ttMensaje.SetToolTip(this.txtNumTelefono, "Ingrese un numero de telefono del cliente");
            this.ttMensaje.SetToolTip(this.txtBuscar, "Ingrese el nombre del cliente que desea buscar");
            this.txtID.Visible = false;
            this.lblID.Visible = false;
        }
        //LOAD
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.HabilitarBotones();
            this.HabilitarTxt(false);
            this.MostrarClientes();
            
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
            this.txtNombres.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtNumTelefono.Text = string.Empty;
            this.txtNIT.Text = string.Empty;
            this.txtBuscar.Text = string.Empty;
        }
        //Metodo para habilitar las cajas de texto
        private void HabilitarTxt(bool valor)
        {
            this.txtNombres.ReadOnly = !valor;
            this.txtApellidos.ReadOnly = !valor;
            this.txtNumTelefono.ReadOnly = !valor;
            this.txtNIT.ReadOnly = !valor;
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
        //Metodo para mostrar a los clientes
        private void MostrarClientes()
        {
            this.dtListado.DataSource = NClientes.MostrarClientes();
            lblTotal.Text = "Total de clientes: " + Convert.ToString(dtListado.Rows.Count);
        }
        //Metodo para buscar cliente
        private void BuscarClienteXNombre()
        {
            this.dtListado.DataSource = NClientes.BuscarClienteXNombre(this.txtBuscar.Text);
            lblTotal.Text = "Total de clientes en la busqueda: " + Convert.ToString(dtListado.Rows.Count);
        }      
        //Boton Buscar en el listado
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarClienteXNombre();
        }
        //Buscar mientras el usuario vaya escribiendo
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.MostrarClientes();
            this.BuscarClienteXNombre();
        }
        //Boton Crear Cliente
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.HabilitarTxt(true);
            this.HabilitarBotones();
            this.txtNombres.Focus();
            this.txtID.Visible = false;
            this.lblID.Visible = false;
            this.txtNIT.Text = "C/F";
        }
        //Boton Guardar Cliente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if(this.txtNombres.Text == string.Empty ||this.txtApellidos.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, los cuales serán marcados.");
                    erroricono.SetError(txtNombres, "Ingrese el nombre del cliente.");
                    erroricono.SetError(txtApellidos, "Ingrese el apellido del cliente.");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NClientes.InsertarCliente
                       (this.txtNombres.Text.ToUpper(),
                        this.txtApellidos.Text.ToUpper(),
                        this.txtNumTelefono.Text,
                        this.txtNIT.Text);
                    }
                    else
                    {
                        rpta = NClientes.EditarCliente
                       (Convert.ToInt32(this.txtID.Text),
                        this.txtNombres.Text.ToUpper(),
                        this.txtApellidos.Text.ToUpper(),
                        this.txtNumTelefono.Text,
                        this.txtNIT.Text);
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se guardo satisfactoriamente el cliente");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizaron satisfactoriamente los datos del cliente");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.HabilitarBotones();
                    this.MostrarClientes();
                    this.Limpiar();
                    this.txtID.Visible = false;
                    this.lblID.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Boton Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtID.Text.Equals(""))
            {
                this.txtNombres.Focus();
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
        //Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.HabilitarTxt(false);
            this.Limpiar();
            this.txtID.Visible = false;
            this.lblID.Visible = false;
        }
        //Llenar cajas de texto al dar doble click en el listado de clientes
        private void dtListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[0].Value);
            this.txtNombres.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[1].Value);
            this.txtApellidos.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[2].Value);
            this.txtNumTelefono.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[3].Value);
            this.txtNIT.Text = Convert.ToString(this.dtListado.CurrentRow.Cells[4].Value);

            this.txtID.Visible = true;
            this.txtID.ReadOnly = true;
            this.lblID.Visible = true;
            
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }
    }
}
