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
                    Id = Convert.ToInt32(fila.ItemArray[0]),
                    Barrio = new Barrio(Convert.ToInt32(fila.ItemArray[1]), fila.ItemArray[2].ToString()),
                    Cuit = Convert.ToInt32(fila.ItemArray[3]),
                    Direccion = fila.ItemArray[4].ToString()
                };
                lista.Add(sucursal);
            }
            return lista;
        }

        public bool PostEmpleado(Empleado empleado)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID_PERSONA", empleado.Id_pers),
                new Parametro("@FECHA_INGRESO", empleado.Fecha_ingreso),
                new Parametro("@ACTIVO", empleado.Activo),
                new Parametro("@SALARIO", empleado.Salario),
                new Parametro("@ID_ROL", empleado.Rol.Id),
                new Parametro("@ID_SUCURSAL", empleado.Sucursal.Id)
            };
            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERT_EMPLEADO", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

    }
}
