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
    public class DProductos
    {

        //Variables
        private int idproducto;
        private string cod_Producto;
        private string nombreprod;
        private string descripcion;
        private decimal precio;
        private string txt;

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public string Cod_Producto { get => cod_Producto; set => cod_Producto = value; }
        public string Nombreprod { get => nombreprod; set => nombreprod = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Txt { get => txt; set => txt = value; }

        //Constructores 
        public DProductos()
        {

        }
        public DProductos(int idproducto, string codproducto, string nombreproducto, string descripcionprod, decimal precio)
        {
            this.Idproducto = idproducto;
            this.Cod_Producto = codproducto;
            this.Nombreprod = nombreprod;
            this.Descripcion = descripcionprod;
            this.Precio = precio;
        }

        //Método Insertar
        public string RegistrarProductos(DProductos productos)
        {
            string rpta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                Sqlcon.Open();

                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SP_Insertar_Producto";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@id_Producto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Direction = ParameterDirection.Output;
                Sqlcmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCod = new SqlParameter();
                ParCod.ParameterName = "@cod_Producto";
                ParCod.SqlDbType = SqlDbType.VarChar;
                ParCod.Size = 50;
                ParCod.Value = productos.Cod_Producto;
                Sqlcmd.Parameters.Add(ParCod);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre_Producto";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = productos.Nombreprod;
                Sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion_Producto";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 1024;
                ParDescripcion.Value = productos.Descripcion;
                Sqlcmd.Parameters.Add(ParDescripcion);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@Precio_Producto";
                ParPrecio.SqlDbType = SqlDbType.Decimal;
                //ParPrecio.Size = 50;
                ParPrecio.Value = productos.Precio;
                Sqlcmd.Parameters.Add(ParPrecio);

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

        //Metodo para editar
        public string EditarProductos(DProductos productos)
        {
            string rpta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                Sqlcon.Open();

                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SP_Editar_Producto";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@id_Producto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = productos.Idproducto;
                Sqlcmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCod = new SqlParameter();
                ParCod.ParameterName = "@cod_Producto";
                ParCod.SqlDbType = SqlDbType.VarChar;
                ParCod.Size = 50;
                ParCod.Value = productos.Cod_Producto;
                Sqlcmd.Parameters.Add(ParCod);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre_Producto";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = productos.Nombreprod;
                Sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion_Producto";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = productos.Descripcion;
                Sqlcmd.Parameters.Add(ParDescripcion);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@Precio_Producto";
                ParPrecio.SqlDbType = SqlDbType.Decimal;
                //ParPrecio.Size = 50;
                ParPrecio.Value = productos.Precio;
                Sqlcmd.Parameters.Add(ParPrecio);


                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No fue posible editar los registros";
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
        //Metodo para mostrar Productos
        public DataTable MostrarProductos()
        {
            DataTable DTResultado = new DataTable("TBL_Productos");
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand Sqlcmd = new SqlCommand();

                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SP_Mostrar_Productos";
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
        //Metodo para buscar Productos por su nombre
        public DataTable BuscarXNombres(DProductos productos)
        {
            DataTable DTResultado = new DataTable("TBL_Productos");
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SP_Buscar_ProductosXNombre";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@txt";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 50;
                ParTextobuscar.Value = productos.Txt;
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
