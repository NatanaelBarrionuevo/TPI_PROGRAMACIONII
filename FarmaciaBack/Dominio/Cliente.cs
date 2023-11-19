using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Cliente : Persona
    {
        private int id_cliente;
        private CondicionIva iva;
        private ObraSocial obra_social;

        public int IdCliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public CondicionIva Iva
        {
            get { return iva; }
            set { iva = value; }
        }
        public ObraSocial ObraSocial
        {
            get { return obra_social; }
            set { obra_social = value; }
        }
        public Cliente(int id_pers, string apellido, string nombre, int id_cliente, CondicionIva iva, ObraSocial os) : base(id_pers, apellido, nombre)
        {
            IdCliente = id_cliente;
            Iva = iva;
            ObraSocial = os;
        }
        public Cliente() : base()
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nId del Cliente: " + IdCliente + "Obra Social: " + ObraSocial.Nombre;
        }
    }
}
