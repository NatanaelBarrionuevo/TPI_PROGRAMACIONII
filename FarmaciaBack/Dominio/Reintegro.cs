using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Reintegro
    {
        private int id;
        private ObraSocial obra_social;
        private Cliente cliente;
        private FormaPago forma_pago;
        private CuentaBancaria cuenta_bancaria;
        private DateTime fecha;
        private List<DetalleReintegro> detalle;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public ObraSocial ObraSocial
        {
            get { return obra_social; }
            set { obra_social = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public FormaPago FormaPago
        {
            get { return forma_pago; }
            set { forma_pago = value; }
        }
        public CuentaBancaria CuentaBancaria
        {
            get { return cuenta_bancaria; }
            set { cuenta_bancaria = value; }
        }
        public DateTime Fecha
        {
            get { return fecha;}
            set { fecha = value; }
        }
        public List<DetalleReintegro> Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public Reintegro(int id, ObraSocial os, Cliente cliente, FormaPago forma, DateTime fecha, List<DetalleReintegro> detalle)
        {
            Id = id;
            ObraSocial = os;
            Cliente = cliente;
            FormaPago = forma;
            Fecha = fecha;
            Detalle = detalle;
        }
        public Reintegro()
        {
            Detalle = new List<DetalleReintegro>();
        }

    }
}
