using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Venta
    {
        private int id;
        private Cliente cliente;
        private Empleado empleado;
        private DateTime fecha;
        private FormaPago forma_pago;
        private CuentaBancaria cuenta_bancaria;
        private bool entrega_propia;
        private string nro_venta;
        private List<DetalleVenta> detalle;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public FormaPago FormaPago
        {
            get { return forma_pago; }
            set { forma_pago = value; }
        }
        public CuentaBancaria CuentaBancaria
        {
            get { return cuenta_bancaria; }
            set {  cuenta_bancaria = value;}
        }
        public bool EntregaPropia
        {
            get { return entrega_propia; }
            set { entrega_propia = value; }
        }
        public string NroVenta
        {
            get { return NroVenta; }
            set { NroVenta = value; }
        }
        public List<DetalleVenta> Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public Venta(int id, Cliente cli, Empleado emp, DateTime fecha, FormaPago forma, CuentaBancaria cuenta, bool entrega, string nro_venta, List<DetalleVenta> det)
        {
            Id = id;
            Cliente = cli;
            Empleado = emp;
            Fecha = fecha;
            FormaPago = forma;
            CuentaBancaria = cuenta;
            EntregaPropia = entrega;
            NroVenta = nro_venta;
            Detalle = det;
        }
        public Venta()
        {
            
        }
    }
}
