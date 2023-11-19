using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Contacto
    {
        private int id;
        private TipoContacto tipo;
        private string valor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public TipoContacto Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
       
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public Contacto(int id, TipoContacto tipo, string valor)
        {
            Id = id;
            Tipo = tipo;
            Valor = valor;
        }
    }
}
