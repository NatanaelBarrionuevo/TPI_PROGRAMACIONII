using FarmaciaBack.Datos.Interfaz;
using FarmaciaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Implementacion
{
    public class MedicoDAO : IMedicoDAO
    {
        public bool PutMedico(Medico medico)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
                {
                    new Parametro("@ID_PERSONA", medico.Id_pers),
                    new Parametro("@MATRICULA", medico.Matricula)
                };
            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERT_MEDICO", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

    }
}
