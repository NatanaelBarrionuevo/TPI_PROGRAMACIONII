using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Dominio
{
    public class Medico : Persona
    {
        private string matricula;
        private ObraSocial obra_social;
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public ObraSocial ObraSocial
        {
            get { return obra_social; }
            set { obra_social = value; }
        }
        public Medico(int id_pers, string apellido, string nombre, string matricula, ObraSocial os) : base(id_pers, apellido, nombre)
        {
            Matricula = matricula;
            ObraSocial = os;
        }
        public Medico() : base()
        {

        }
    }
}
