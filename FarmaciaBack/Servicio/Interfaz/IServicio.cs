using FarmaciaBack.Datos.Interfaz;
using FarmaciaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Servicio.Interfaz
{
    public interface IServicio
    {
        //Cliente
        List<CondicionIva> ConsultarCondicionIva();
        List<ObraSocial> ConsultarObraSocial();
        List<CategoriaOS> ConsultarCategoriaOS();
        bool CargarCliente(Cliente cliente);

        //Proveedor
        List<Transporte> ConsultarTransporte();
        List<TipoProveedor> ConsultarTipoProveedor();
        bool CargarProveedor(Proveedor proveedor);

        //Empleado
        List<Sucursal> ConsultarSucursal();
        bool CargarEmpleado(Empleado empleado);
    }
}
