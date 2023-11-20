using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class DetalleCompra
    {
        private int id;
        private string nro_compra;
        private Producto producto;
        private int cantidad;
        private double precio_compra;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NroCompra
        {
            get { return nro_compra;}
            set { nro_compra = value;}
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
            get { return precio_compra;}
            set { precio_compra = value;}
        }
        public DetalleCompra(int id, string nro_compra, Producto producto, int catidad, double precio)
        {
            Id = id;
            NroCompra = nro_compra;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
        }
        public DetalleCompra()
        {
            
        }
    }
}