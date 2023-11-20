using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class CuentaBancaria
    {
        private int id;
        private Sucursal sucursal;
        private string descripcion;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Sucursal Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public CuentaBancaria(int id,Sucursal sucursal, string desc)
        {
            this.id = id;
            Sucursal = sucursal;
            Descripcion = desc;
        }
        public CuentaBancaria()
        {

        }
    }
}
