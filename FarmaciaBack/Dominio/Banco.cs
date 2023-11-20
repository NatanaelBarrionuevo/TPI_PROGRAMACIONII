using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Banco
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
        public Banco(int id, string desc)
        {
            this.id = id;
            Nombre = desc;
        }
        public Banco()
        {

        }
    }
}
