using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Producto
    {
        private int id_producto;
        private string descripcion;
        private double precio_unitario;
        private bool estado;
        private DateTime fecha_vencimiento;
        private int stock;
        private int stock_minimo;
        private int codigo_barra;
        private bool receta;
        private Unidad unidad;
        private TipoProducto tipo;
        private double descuento;
        public int Id
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Precio
        {
            get { return precio_unitario; }
            set { precio_unitario = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public DateTime FechaVencimiento
        {
            get { return fecha_vencimiento; }
            set {  fecha_vencimiento = value;}
        }
        public int Stock
        {
            get { return stock; }
            set {  stock = value; } 
        }
        public int StockMinimo
        {
            get { return stock_minimo;}
            set { stock_minimo = value;}
        }
        public int CodigoBarra
        {
            get { return codigo_barra; }
            set { codigo_barra = value; }
        }
    ´   public bool Receta
        {
            get { return receta; }
            set { receta = value; }
        }
        public Unidad Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        public TipoProducto Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public Producto(int id, string desc, double precio)
        {
            
        }
        public Producto()
        {
            
        }
    }
}
