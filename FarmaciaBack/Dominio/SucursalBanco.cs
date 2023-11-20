using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class SucursalBanco
    {
        private int id;
        private string nombre;
        private Barrio barrio;
        private Banco banco;
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
        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        public Banco Banco
        {
            get { return banco; }
            set { banco  = value; } 
        }
        public SucursalBanco(int id, string nombre, Barrio barrio, Banco banco)
        {
            this.id = id;
            Nombre = nombre;
            Barrio = barrio;
            Banco = banco;
        }
        public SucursalBanco()
        {

        }
    }
}
