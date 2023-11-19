using FarmaciaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Interfaz
{
    public interface IClienteDAO
    {
        List<CondicionIva> GetCondicionIva();
        List<ObraSocial> GetObraSocial();
        List<CategoriaOS> GetCategoriaOS();
        bool PushCliente(Cliente cliente);

    }
}
