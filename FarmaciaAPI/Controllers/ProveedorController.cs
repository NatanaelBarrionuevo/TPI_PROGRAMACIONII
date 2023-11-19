using FarmaciaBack.Dominio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        //private ProveedorDAO dao;
        public ProveedorController()
        {
            //dao = new ProveedorDAO();
        }
        [HttpGet("CondicionIva")]
        public IActionResult GetCondicionIva() // IActionResult devuelve un Json y un Codigo OK 200
        {/*
            if (dao.ObtenerCondicionIva() != null)
            {
                return Ok(dao.ObtenerCondicionIva());
            }*/
            return NoContent();
        }

        [HttpGet("Transporte")]
        public IActionResult GetTransporte() // IActionResult devuelve un Json y un Codigo OK 200
        {/*
            if (dao.ObtenerTransporte() != null)
            {
                return Ok(dao.ObtenerTransporte());
            }*/
            return NoContent();
        }

        [HttpGet("Tipo")]
        public IActionResult GetTipo() // IActionResult devuelve un Json y un Codigo OK 200
        {/*
            if (dao.ObtenerTipo() != null)
            {
                return Ok(dao.ObtenerTipo());
            }*/
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
