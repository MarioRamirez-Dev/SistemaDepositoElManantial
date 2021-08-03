using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Deposito el Manantial", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Mostrar Fecha y hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }
        //Boton Iniciar Sesion
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
      
                if (this.txtUsuario.Text == String.Empty || this.txtPassword.Text == String.Empty)
                {
                    
                    MensajeError("Falta ingresar algunos datos, los cuales serán marcados.");
                    erroricono.SetError(txtUsuario, "Ingrese el usuario.");
                    erroricono.SetError(txtPassword, "Ingrese la contraseña.");
                }
                else
                {
                    if (this.txtUsuario.Text.Equals("User") || this.txtPassword.Text.Equals("user123"))
                    {
                        
                        MDIParent principal = new MDIParent();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MensajeError("Usuario y/o Contraseña incorrecto, porfavor verifique.");
                    }
                }
            }
            catch(Exception ex)
            {
                MensajeError("ERROR con código 1005.6, Porfavor Comuniquese con su proveedor.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
