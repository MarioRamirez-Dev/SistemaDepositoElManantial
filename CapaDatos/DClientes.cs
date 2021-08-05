using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CapaDatos{
    public class DClientes{
        //Variables
        private int idcliente;
        private string nombrecliente;
        private string apellidocliente;
        private string num_telefono;
        private string nit;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Nombrecliente { get => nombrecliente; set => nombrecliente = value; }
        public string Apellidocliente { get => apellidocliente; set => apellidocliente = value; }
        public string Num_telefono { get => num_telefono; set => num_telefono = value; }
        public string NIT { get => nit; set => nit = value; }

        //Constructores 
        public DClientes()
        {

        }
        public DClientes(int idcliente, string nombrecliente, string apellidoscliente, string numtelefono, string nit)
        {
            this.Idcliente = idcliente;
            this.Nombrecliente = nombrecliente;
            this.Apellidocliente = apellidoscliente;
            this.Num_telefono = numtelefono;
            this.NIT = nit;
        }

        //Método Insertar
        public string RegistrarCliente(DClientes clientes)
        {
            string rpta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                Sqlcon.Open();

                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SP_Insertar_Cliente";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@Id_Cliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Direction = ParameterDirection.Output;
                Sqlcmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@Nombre_Cliente";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = clientes.Nombrecliente;
                Sqlcmd.Parameters.Add(ParNombres);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@Apellido_Cliente";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = clientes.Apellidocliente;
                Sqlcmd.Parameters.Add(ParApellido);

                SqlParameter ParTelefonoP = new SqlParameter();
                ParTelefonoP.ParameterName = "@Numero";
                ParTelefonoP.SqlDbType = SqlDbType.VarChar;
                ParTelefonoP.Size = 50;
                ParTelefonoP.Value = clientes.Num_telefono;
                Sqlcmd.Parameters.Add(ParTelefonoP);

                SqlParameter ParNIT = new SqlParameter();
                ParNIT.ParameterName = "@NIT";
                ParNIT.SqlDbType = SqlDbType.VarChar;
                ParNIT.Size = 15;
                ParNIT.Value = clientes.NIT;
                Sqlcmd.Parameters.Add(ParNIT);

                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No fue posible ingresar los registros";
            }
            catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if(Sqlcon.State == ConnectionState.Open)
                {
                    Sqlcon.Close();
                }
            }
            return rpta;
        }

        //Metodo para editar
        public string EditarCliente(DClientes clientes)
        {
            string rpta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                Sqlcon.Open();

                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SP_Editar_cliente";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@Id_Cliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = clientes.Idcliente;
                Sqlcmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@Nombres_Cliente";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = clientes.Nombrecliente;
                Sqlcmd.Parameters.Add(ParNombres);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@Apellidos_Cliente";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = clientes.Apellidocliente;
                Sqlcmd.Parameters.Add(ParApellido);

                SqlParameter ParTelefonoP = new SqlParameter();
                ParTelefonoP.ParameterName = "@Num_Telefono";
                ParTelefonoP.SqlDbType = SqlDbType.VarChar;
                ParTelefonoP.Size = 50;
                ParTelefonoP.Value = clientes.Num_telefono;
                Sqlcmd.Parameters.Add(ParTelefonoP);


                SqlParameter ParNIT = new SqlParameter();
                ParNIT.ParameterName = "@NIT";
                ParNIT.SqlDbType = SqlDbType.VarChar;
                ParNIT.Size = 15;
                ParNIT.Value = clientes.NIT;
                Sqlcmd.Parameters.Add(ParNIT);

                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No fue posible ingresar los registros";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                {
                    Sqlcon.Close();
                }
            }
            return rpta;
        }
        //Metodo para mostrar clientes
        public DataTable MostrarClientes()
        {
            DataTable DTResultado = new DataTable("TBL_Clientes");
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand Sqlcmd = new SqlCommand();

                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SP_Mostrar_Cliente";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(DTResultado);
            }
            catch (Exception ex)
            {
                DTResultado = null;
            }

            return DTResultado;
        }
        //Metodo para buscar clientes por su nombre
        public DataTable BuscarXNombres(string Txt)
        {
            DataTable DTResultado = new DataTable("TBL_Clientes");
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SP_Buscar_ClienteXNombre";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@txt";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 50;
                ParTextobuscar.Value = Txt;
                Sqlcmd.Parameters.Add(ParTextobuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(DTResultado);
            }
            catch (Exception ex)
            {
                DTResultado = null;
            }

            return DTResultado;
        }
    }
}
