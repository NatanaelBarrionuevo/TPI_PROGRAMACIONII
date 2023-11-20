using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class DetalleVenta
    {
        private int id_detalle;
        private string nro_venta;
        private Producto producto;
        private int cantidad;
        private double precio;

        public int IdDetalle
        {
            get { return id_detalle; }
            set { id_detalle = value; }
        }
        public string NroVenta
        {
            get { return nro_venta; }
            set { nro_venta = value; }
        }
        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public DetalleVenta(int id, string nro_vta, Producto producto, int cant, double precio)
        {
            IdDetalle = id;
            NroVenta = nro_vta;
            Producto = producto;
            Precio = precio;
        }
        public DetalleVenta()
        {
            
        }
    }
}
