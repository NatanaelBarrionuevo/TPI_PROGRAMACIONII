using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Receta
    {
        private int id;
        private ObraSocial obra_social;
        private Cliente cliente;
        private Medico medico;
        private Solicitud solicitud;
        private DateTime fecha_emision;
        private DateTime fecha_vencimiento;

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
        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }
        public Solicitud Solicitud
        {
            get { return solicitud; }
            set { solicitud = value; }
        }
        public DateTime FechaEmision
        {
            get { return fecha_emision; }
            set { fecha_emision = value; }
        }
        public DateTime FechaVencimiento
        {
            get { return fecha_vencimiento; }
            set { fecha_vencimiento = value; }
        }
        public Receta(int id, ObraSocial os, Cliente cli, Medico med, Solicitud solicitud, DateTime fec_emision, DateTime fec_vento)
        {
            Id = id;
            ObraSocial = os;
            Cliente = cli;
            Medico = med;
            Solicitud = solicitud;
            FechaEmision = fec_emision;
            FechaVencimiento = fec_vento;
        }
        public Receta()
        {
            
        }
    }
}
