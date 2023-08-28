using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaBanco
{
    internal class Cuenta
    {
        public string cbu { get; set; }
        public double saldo { get; set; }

        public int tipoCuenta { get; set; }
        public DateTime ultimoMov { get; set; }

        public Cuenta(string cbu,double saldo,DateTime ultimoMov)
        {
             this.cbu = cbu;
            this.saldo = saldo;
            this.ultimoMov = ultimoMov;
        }

        public string MostrarCuenta()
        {
            return "CBU:"+cbu+" SALDO: "+saldo;
        }


    }
}
