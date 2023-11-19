using FarmaciaBack.Dominio;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        
        public ProveedorController()
        {
            
        }
        [HttpGet("CondicionIva")]
        public IActionResult GetCondicionIva() // IActionResult devuelve un Json y un Codigo OK 200
        {
            List<CondicionIva> lista = Servicio.ObtenerIntancia().ConsultarCondicionIva();
            if ( lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }

        [HttpGet("Transporte")]
        public IActionResult GetTransporte() // IActionResult devuelve un Json y un Codigo OK 200
        {
            List<Transporte> lista = Servicio.ObtenerIntancia().ConsultarTransporte();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }

        [HttpGet("Tipo")]
        public IActionResult GetTipo() // IActionResult devuelve un Json y un Codigo OK 200
        {
            List<TipoProveedor> lista = Servicio.ObtenerIntancia().ConsultarTipoProveedor();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }

        // POST api/<ProveedorController>
        [HttpPost]
        public IActionResult Post([FromBody] Proveedor proveedor)
        {
            //dentro de un try catch
            try
            {
                if (proveedor == null)
                {
                    return BadRequest("Se esperaba un proveedor con todos los datos");
                }
                //if (proveedor.) validaciones por si es un objeto valido.
                /*if (dao.CrearProveedor(proveedor))
                {
                    return Ok("Proveedor registrado con exito");
                }*/
                else
                {
                    return StatusCode(500, "No se pudo registrar el proveedor");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
    }
}
