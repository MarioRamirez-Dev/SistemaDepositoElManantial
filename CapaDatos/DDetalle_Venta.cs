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
    public class DDetalle_Venta
    {
        private int id_detalle_venta;
        private int id_venta;
        private int id_Producto;
        private int cantidad;
        private Decimal precio_Venta;
        private Decimal descuento;
        

        public int Id_detalle_venta { get => id_detalle_venta; set => id_detalle_venta = value; }
        public int Id_venta { get => id_venta; set => id_venta = value; }
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio_Venta { get => precio_Venta; set => precio_Venta = value; }
        public decimal Descuento { get => descuento; set => descuento = value; }

        //Constructores
        public DDetalle_Venta()
        {

        }
        public DDetalle_Venta(int iddetalle, int idventa, int idprod, int cantidad, decimal prec, decimal desc)
        {
            this.Id_detalle_venta = iddetalle;
            this.Id_venta = idventa;
            this.Id_Producto = idprod;
            this.Cantidad = cantidad;
            this.Precio_Venta = prec;
            this.Descuento = desc;
        }

        public string InsertarDetalle(DDetalle_Venta Detalle_Venta,
                    ref SqlConnection SqlCon, ref SqlTransaction SqlTran)
        {
            string rpta = " ";
            try
            {
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.Transaction = SqlTran;
                Sqlcmd.CommandText = "SP_Insertar_Detalle_Venta";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle = new SqlParameter();
                ParIddetalle.ParameterName = "@Id_Detalle";
                ParIddetalle.SqlDbType = SqlDbType.Int;
                ParIddetalle.Direction = ParameterDirection.Output;
                Sqlcmd.Parameters.Add(ParIddetalle);

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@Id_Venta";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = Detalle_Venta.Id_venta;
                Sqlcmd.Parameters.Add(ParIdVenta);

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@Id_Prod";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Detalle_Venta.Id_Producto;
                Sqlcmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Detalle_Venta.Cantidad;
                Sqlcmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@Precio";
                ParPrecio.SqlDbType = SqlDbType.Decimal;
                ParPrecio.Value = Detalle_Venta.Precio_Venta;
                Sqlcmd.Parameters.Add(ParPrecio);

                SqlParameter ParDesc = new SqlParameter();
                ParDesc.ParameterName = "@Descuento";
                ParDesc.SqlDbType = SqlDbType.Decimal;
                ParDesc.Value = Detalle_Venta.Descuento;
                Sqlcmd.Parameters.Add(ParDesc);

                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No fue posible ingresar los registros";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
    }
}
