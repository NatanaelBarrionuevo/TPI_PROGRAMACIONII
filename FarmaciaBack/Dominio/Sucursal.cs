using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Sucursal
    {
        private int id;
        private int cuit;
        private string direccion;
        private Barrio barrio;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public Sucursal(int cuit, Barrio barrio)
        {
            Cuit = cuit;
            Barrio = barrio;
        }
        public Sucursal()
        {
              
        }
    }
}
