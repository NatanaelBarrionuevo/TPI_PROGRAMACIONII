using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaBanco.Dominio
{
    internal class Cliente
    {
        List<Cuenta>lstCuentas = new List<Cuenta>();

        public int id { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }

        public Cliente(int id,string nombre,string apellido,string dni)
        {
            this.id = id;
            this.nombre = nombre;
            this.dni = dni;
            this.apellido = apellido;
        }

    }
}
