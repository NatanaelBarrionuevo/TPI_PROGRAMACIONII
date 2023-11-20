using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class FormaPago
    {
        private int id;
        private string forma;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Forma
        {
            get { return forma; }
            set { forma = value; }
        }
        public FormaPago(int id, string desc)
        {
            this.id = id;
            Forma = desc;
        }
        public FormaPago()
        {

        }
    }
}
