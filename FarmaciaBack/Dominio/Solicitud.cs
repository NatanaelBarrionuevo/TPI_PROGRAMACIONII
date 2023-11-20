using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Solicitud
    {
        private int id;
        private DateTime fecha_peticion;
        private DateTime fecha_retorno;
        private bool estado;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime FechaPeticion
        {
            get { return fecha_peticion; }
            set { fecha_peticion = value; }
        }
        public DateTime FechaRetorno
        {
            get { return fecha_retorno; }
            set { fecha_retorno = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Solicitud(int id, DateTime fec_peticion, DateTime fec_retorno, bool estado)
        {
            Id = id;
            FechaPeticion = fec_peticion;
            FechaRetorno = fec_retorno;
            Estado = estado;
        }
        public Solicitud()
        {
            
        }
    }
}
