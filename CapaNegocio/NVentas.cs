using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NVentas
    {
        public static string InsertarVenta(int idcliente, DateTime fecha , DateTime hora, DataTable dtDetalle)
        {
            DVentas obj = new DVentas();
            obj.Id_Cliente = idcliente;
            obj.Fecha = fecha;
            obj.Hora = hora;

            List<DDetalle_Venta> detalles = new List<DDetalle_Venta>();
            foreach (DataRow row in dtDetalle.Rows)
            {
                DDetalle_Venta detalle = new DDetalle_Venta();

                
                detalle.Id_Producto = Convert.ToInt32(row["Id_Producto"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["Cantidad_Productos"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["Precio_Venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["Descuento"].ToString());                
                detalles.Add(detalle);
            }

            return obj.InsertarVenta(obj, detalles);
        }
        /*/Metodo Eliminar
        /*/


        public static DataTable MostrarVentas()
        {
            return new DVentas().MostrarVenta();
        }
        //Metodo buscar fechas
        public static DataTable BuscarFechas(DateTime txt1, DateTime txt2)
        {
            DVentas OBJ = new DVentas();
            return OBJ.BuscarXFechas(txt1,txt2);
        }
        public static DataTable MostrarDetalles(int txt)
        {
            DVentas obj = new DVentas();
            return obj.MostrarDetalleVenta(txt);
        }
    }
}
