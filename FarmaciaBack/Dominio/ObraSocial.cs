using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class ObraSocial
    {
        private int id;
        private CategoriaOS categoria;
        private string nombre;
        private double descuento;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public CategoriaOS Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public ObraSocial(int id, CategoriaOS cat, string nombre, double descuento)
        {
            Id = id;
            Categoria = categoria;
            Nombre = nombre;
            Descuento = descuento;
        }
        public ObraSocial()
        {
            
        }
    }
}
