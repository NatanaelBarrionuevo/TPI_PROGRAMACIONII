using FarmaciaBack.Datos.Interfaz;
using FarmaciaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Implementacion
{
    public class ProveedorDAO : IProveedorDAO
    {
        public bool PostProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public List<TipoProveedor> GetTipoProveedor()
        {
            TipoProveedor tipo;
            List<TipoProveedor> lista = new List<TipoProveedor>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("", new List<Parametro>());

            foreach (DataRow fila in tabla.Rows)
            {
                tipo = new TipoProveedor(Convert.ToInt32(fila.ItemArray[0]), fila.ItemArray[1].ToString());
                lista.Add(tipo);
            }
            return lista;
        }

        public List<Transporte> GetTransporte()
        {
            Transporte transporte;
            List<Transporte> lista = new List<Transporte>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("", new List<Parametro>());

            foreach (DataRow fila in tabla.Rows)
            {
                transporte = new Transporte(Convert.ToInt32(fila.ItemArray[0]), fila.ItemArray[1].ToString());
                lista.Add(transporte);
            }
            return lista;
        }
    }
}
