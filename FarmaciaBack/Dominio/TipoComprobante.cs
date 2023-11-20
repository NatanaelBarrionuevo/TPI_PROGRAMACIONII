using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class TipoComprobante
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
        public TipoComprobante(int id, string desc)
        {
            this.id = id;
            Descripcion = desc;
        }
        public TipoComprobante()
        {

        }
    }
}
