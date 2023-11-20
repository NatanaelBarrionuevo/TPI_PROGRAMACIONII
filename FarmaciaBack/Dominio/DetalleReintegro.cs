using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class DetalleReintegro
    {
        private int id_detalle;
        private int id_reintegro;
        private Producto producto;
        private int cantidad;
        private double precio;

        public int IdDetalle
        {
            get { return id_detalle; }
            set { id_detalle = value; }
        }
        public int IdReintegro
        {
            get { return id_reintegro; }
            set { id_reintegro = value; }
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
        public DetalleReintegro(int id_det, int id_reintegro, Producto producto, int cant, double precio)
        {
            IdDetalle = id_det;
            IdReintegro = id_reintegro;
            Producto = producto;
            Cantidad = cant;
            Precio = precio;
        }
        public DetalleReintegro()
        {
            
        }
    }
}
