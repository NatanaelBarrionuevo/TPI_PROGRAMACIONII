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
    public class PersonaDAO : IPerosnaDAO
    {
        public List<Barrio> GetBarrio()
        {
            Barrio barrio;
            List<Barrio> lista = new List<Barrio>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("", new List<Parametro>());

            foreach(DataRow fila in tabla.Rows)
            {
                barrio = new Barrio(Convert.ToInt32(fila.ItemArray[0]), fila.ItemArray[1].ToString());
                lista.Add(barrio);
            }
            return lista;
        }

        public bool PutPersona(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
