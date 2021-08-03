using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NClientes
    {
        public static string InsertarCliente(string nombres, string apellidos, string num, string nit)
        {
            DClientes obj = new DClientes();
            obj.Nombrecliente = nombres;
            obj.Apellidocliente = apellidos;
            obj.Num_telefono = num;
            obj.NIT = nit;

            return obj.RegistrarCliente(obj);
        }
        public static string EditarCliente(int idcliente, string nombres, string apellidos, string num, string nit)
        {
            DClientes Obj = new DClientes();
            Obj.Idcliente = idcliente;
            Obj.Nombrecliente = nombres;
            Obj.Apellidocliente = apellidos;
            Obj.Num_telefono = num;
            Obj.NIT = nit;

            return Obj.EditarCliente(Obj);
        }

        public static DataTable MostrarClientes()
        {
            return new DClientes().MostrarClientes();
        }
        public static DataTable BuscarClienteXNombre(string txt)
        {
            DClientes Obj = new DClientes();        

            return Obj.BuscarXNombres(txt);
        }
    }
}
