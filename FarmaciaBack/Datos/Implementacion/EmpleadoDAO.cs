using FarmaciaBack.Datos.Interfaz;
using FarmaciaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Implementacion
{
    public class EmpleadoDAO : IEmpleadoDAO
    {
        public List<Sucursal> GetSucursal()
        {
            Sucursal sucursal;
            List<Sucursal> lista = new List<Sucursal>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("", new List<Parametro>());

            foreach (DataRow fila in tabla.Rows)
            {
                sucursal = new Sucursal()
                {
                    Cuit = Convert.ToInt32(fila["CUIT"]),
                    Barrio = new Barrio(Convert.ToInt32(fila["ID_BARRIO"]), fila["BARRIO"].ToString()),
                    Direccion = fila["DIRECCION"].ToString()
                };
                lista.Add(sucursal);
            }
            return lista;
        }
        public bool PostEmpleado()
        {
            throw new NotImplementedException();
        }
    }
}
