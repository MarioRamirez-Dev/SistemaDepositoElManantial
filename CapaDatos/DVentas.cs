using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CapaDatos
{
    public class DVentas
    {
        //Variables
        private int id_Venta;
        private int id_Cliente;
        private DateTime fecha;
        private DateTime hora;
        //Metodos Getter and Setter
        public int Id_Venta { get => id_Venta; set => id_Venta = value; }
        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
       //Constructores
        public DVentas()
        {

        }
        public DVentas(int idventa ,int idcliente ,DateTime fecha, DateTime hora)
        {
            this.Id_Venta = idventa;
            this.Id_Cliente = idcliente;
            this.Fecha = fecha;
            this.Hora = hora;
        }
        //Metodo para Insertar Ventas         
        public string InsertarVenta (DVentas Ventas, List<DDetalle_Venta> Detalle_Venta)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlTransaction SqlTran = SqlCon.BeginTransaction();
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.Transaction = SqlTran;
                Sqlcmd.CommandText = "SP_Insertar_Venta";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@Id_Venta";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Direction = ParameterDirection.Output;
                Sqlcmd.Parameters.Add(ParIdVenta);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@Id_Cliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Ventas.Id_Cliente;
                Sqlcmd.Parameters.Add(ParIdCliente);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Ventas.Fecha;
                Sqlcmd.Parameters.Add(ParFecha);

                SqlParameter ParHora = new SqlParameter();
                ParHora.ParameterName = "@Hora";
                ParHora.SqlDbType = SqlDbType.DateTime2;
                ParHora.Value = Ventas.Hora;
                Sqlcmd.Parameters.Add(ParHora);

                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No fue posible ingresar los registros";

                if (rpta.Equals("OK"))
                {
                    //Obtener el codigo del ingreso generado 
                    this.Id_Venta = Convert.ToInt32(Sqlcmd.Parameters["@Id_Venta"].Value);
                    foreach (DDetalle_Venta det in Detalle_Venta)
                    {
                        det.Id_venta = this.Id_Venta;
                        //Llamar al metodo insertar del detalle de venta
                        rpta = det.InsertarDetalle(det, ref SqlCon, ref SqlTran);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                    }              
                }
                if (rpta.Equals("OK"))
                {
                    SqlTran.Commit();
                }
                else
                {
                    SqlTran.Rollback();
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        /*/Metodo Eliminar Ventas
        public string Eliminar(DVentas venta)
        {

        }
        /*/

        //Metodo Mostrar
        public DataTable MostrarVenta()
        {
            DataTable dtResultado = new DataTable("TBL_Ventas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_Mostrar_Ventas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);
            }
            catch(Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;

        }
        //Metodo Mostrar Detalle
        public DataTable MostrarDetalleVenta(int Txt)
        {
            DataTable dtResultado = new DataTable("TBL_Detalle_Venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_Mostrar_Detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTxt = new SqlParameter();
                ParTxt.ParameterName = "@txt";
                ParTxt.SqlDbType = SqlDbType.Int;
                ParTxt.Value = Txt;
                SqlCmd.Parameters.Add(ParTxt);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;

        }
        //Metodo para buscar ventas entre fechas
        public DataTable BuscarXFechas(DateTime txt1, DateTime txt2)
        {
            DataTable dtResultado = new DataTable("TBL_Ventas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_Buscar_Venta_Fechas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTxt1 = new SqlParameter();
                ParTxt1.ParameterName = "@txt1";
                ParTxt1.SqlDbType = SqlDbType.DateTime;
                ParTxt1.Value = txt1;
                SqlCmd.Parameters.Add(ParTxt1);

                SqlParameter ParTxt2 = new SqlParameter();
                ParTxt2.ParameterName = "@txt2";
                ParTxt2.SqlDbType = SqlDbType.DateTime;
                ParTxt2.Size = 50;
                ParTxt2.Value = txt2;
                SqlCmd.Parameters.Add(ParTxt2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }


    }
}
