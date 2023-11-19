using FarmaciaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Interfaz
{
    public interface IProveedorDAO
    {
        List<Transporte> GetTransporte();
        List<TipoProveedor> GetTipoProveedor();
        bool PostProveedor(Proveedor proveedor);
    }
}
