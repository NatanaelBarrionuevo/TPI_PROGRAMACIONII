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
    public class ClienteDAO : IClienteDAO
    {
        public List<CategoriaOS> GetCategoriaOS()
        {
            CategoriaOS categoria;
            List<CategoriaOS> lista = new List<CategoriaOS>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("", new List<Parametro>());

            foreach(DataRow fila in  tabla.Rows) 
            { 
                categoria = new CategoriaOS(Convert.ToInt32(fila.ItemArray[0]), fila.ItemArray[1].ToString());
                lista.Add(categoria);
            }
            return lista;
            
        }

        public List<CondicionIva> GetCondicionIva()
        {
            CondicionIva iva;
            List<CondicionIva> lista = new List<CondicionIva>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("", new List<Parametro>());

            foreach (DataRow fila in tabla.Rows)
            {
                iva = new CondicionIva(Convert.ToInt32(fila.ItemArray[0]), fila.ItemArray[1].ToString());
                lista.Add(iva);
            }
            return lista;
        }

        public List<ObraSocial> GetObraSocial()
        {
            ObraSocial obra_social;
            List<ObraSocial> lista = new List<ObraSocial>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("", new List<Parametro>());

            foreach (DataRow fila in tabla.Rows)
            {
                
                obra_social = new ObraSocial()
                {
                    Id = Convert.ToInt32(fila.ItemArray[0]),
                    Categoria = new CategoriaOS(Convert.ToInt32(fila.ItemArray[1]), fila.ItemArray[2].ToString()),
                    Nombre = fila.ItemArray[3].ToString(),
                    Descuento = Convert.ToDouble(fila.ItemArray[4])
                };
                lista.Add(obra_social);
            }
            return lista;
        }

        public bool PushCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
