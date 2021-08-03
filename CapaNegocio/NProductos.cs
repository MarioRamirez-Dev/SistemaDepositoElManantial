using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NProductos
    {
        public static string InsertarProducto(string cod, string prod, string desc, decimal prec)
        {
            DProductos obj = new DProductos();
            obj.Cod_Producto = cod;
            obj.Nombreprod = prod;
            obj.Descripcion = desc;
            obj.Precio = prec;
            return obj.RegistrarProductos(obj);
        }

        public static string EditarProductos(int id, string cod, string prod, string desc, decimal prec)
        {
            DProductos obj = new DProductos();
            obj.Idproducto = id;
            obj.Cod_Producto = cod;
            obj.Nombreprod = prod;
            obj.Descripcion = desc;
            obj.Precio = prec;
            return obj.EditarProductos(obj);
        }

        public static DataTable MostrarProductos()
        {
            DProductos obj = new DProductos();
            return obj.MostrarProductos();
        }

        public static DataTable BuscarXProducto(string txt)
        {
            DProductos obj = new DProductos();
            obj.Txt = txt;
            return obj.BuscarXNombres(obj);
        }
    }
}
