using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Empleado : Persona
    {
        private int id_empleado;
        private DateTime fecha_ingreso;
        private DateTime fecha_baja;
        private bool activo;
        private double salario;
        private Rol rol;
        private Sucursal sucursal;

        public int IdEmpleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }
        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }
        public DateTime Fecha_baja
        {
            get { return fecha_baja; }
            set { fecha_baja = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Rol Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        public Sucursal Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

        public Empleado(int id_pers, string nombre, string apellido, int id_emp, DateTime fec_ingreso, double salario, Rol rol, Sucursal sucursal) : base(id_pers, nombre, apellido)
        {
            IdEmpleado = id_emp;
            Fecha_ingreso = fec_ingreso;
            Salario = salario;
            Rol = rol;
            Sucursal = sucursal;
        }

        public Empleado() : base()
        {

        }

        public override string ToString()
        {
            string aux = Activo ? "Si" : "No";
            return base.ToString() + "\nId del Empleado: " + IdEmpleado + "\nFecha de Ingreso: " + fecha_ingreso + "\nActivo: " + aux;
        }
    }
}
