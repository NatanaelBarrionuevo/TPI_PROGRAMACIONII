using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class TipoProveedor
    {
        private int id;
        private string nombre;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public TipoProveedor(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public TipoProveedor()
        {
            
        }
    }
}

