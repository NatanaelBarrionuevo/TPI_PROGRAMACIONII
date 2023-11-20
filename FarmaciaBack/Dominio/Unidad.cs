using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Unidad
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
        public Unidad(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public Unidad()
        {
            
        }
    }
}
