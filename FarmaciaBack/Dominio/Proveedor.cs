using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Proveedor : Persona
    {
        private int id_proveedor;//Me parece que con el cuit ya estaria par aidentificar al proveedor.
        private TipoProveedor tipo;
        private int cuit;
        //private RazonSocial razon; Me parece que para normalizar la BD, deberiamos crear una tabla auxiliar.
        private string razon_social;
        private Transporte transporte;

        public int IdProveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }
        public TipoProveedor Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public string RazonSocial
        {
            get { return razon_social; }
            set { razon_social = value; }
        }
        public Transporte Transporte
        {
            get { return transporte; }
            set { transporte = value; }
        }
        public Proveedor(int id_pers, string apellido, string nombre, int cuit) : base(id_pers, apellido, nombre)
        {
            Cuit = cuit;
        }
        public Proveedor() : base()
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nCUIT: " + cuit + "\nRazon Social: " + RazonSocial;
        }
    }
}
