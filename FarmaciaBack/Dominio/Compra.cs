using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Compra
    {
        private int id;
        private string nro_compra;
        private TipoComprobante comprobante;
        private Proveedor proveedor;
        private DateTime fecha;
        private FormaPago forma_pago;
        private CuentaBancaria cuenta_bancaria;
        private Transporte transporte;
        private List<DetalleCompra> detalle;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NroCompra
        {
            get { return nro_compra; }
            set { nro_compra = value; }
        }
        public TipoComprobante Comprobante
        {
            get { return comprobante; }
            set { comprobante = value; }
        }
        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
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
            set { cuenta_bancaria = value; }
        }
        public Transporte Transporte
        {
            get { return transporte; }
            set { transporte = value; }
        }
        public List<DetalleCompra> Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public Compra(int id, string nro_compra, TipoComprobante comprobante, Proveedor proveedor, DateTime fecha, FormaPago formaPago, List<DetalleCompra> detalle, CuentaBancaria cuentaBancaria, Transporte transporte)
        {
            this.id = id;
            NroCompra = nro_compra;
            Comprobante = comprobante;
            Proveedor = proveedor;
            Fecha = fecha;
            FormaPago = formaPago;
            CuentaBancaria = cuentaBancaria;
            Transporte = transporte;
            Detalle = detalle;
        }
        public Compra()
        {
            Detalle = new List<DetalleCompra>();
        }
    }
}
