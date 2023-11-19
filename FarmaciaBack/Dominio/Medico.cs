using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Medico : Persona
    {
        private int matrcula;
        private ObraSocial obra_social;
        public int Matricula
        {
            get { return matrcula; }
            set { matrcula = value; }
        }
        public ObraSocial ObraSocial
        {
            get { return obra_social; }
            set { obra_social = value; }
        }
        public Medico(int id_pers, string apellido, string nombre, int matricula, ObraSocial os) : base(id_pers, apellido, nombre)
        {
            Matricula = matrcula;
            ObraSocial = os;
        }
        public Medico() : base()
        {

        }
    }
}
