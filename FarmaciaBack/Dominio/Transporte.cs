using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Transporte
    {
        private int id;
        private string descripcion;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Transporte(int id, string desc)
        {
            Id = id;
            Descripcion = desc;
        }
        public Transporte()
        {
            
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
