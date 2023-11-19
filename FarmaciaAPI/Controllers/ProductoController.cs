using FarmaciaBack.Dominio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        //private ProductoDAO dao;
        public ProductoController()
        {
            //dao = new PersonasDAO();
        }
        [HttpGet("UnidadMedida")]
        public IActionResult GetUnidadMedida() //devuelve un Json y un Codigo OK 200
        {/*
            if (dao.ObtenerUnidadMedida() != null)
            {
                return Ok(dao.ObtenerUnidadMedida());
            }*/
            return NoContent();
        }
        [HttpGet("TipoProducto")]
        public IActionResult GetTipoProducto()
        {/*
            if (dao.ObtenerTipoProducto() != null)
            {
                return Ok(dao.ObtenerTipoProducto());
            }*/
            return NoContent();
        }
        /* POST api/<ProductoController>
        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            //dentro de un try catch
            try
            {
                if (producto == null)
                {
                    return BadRequest("Se esperaba un producto completo");
                }
                //if (producto.) validaciones por si es un objeto valido.
                if (dao.CrearProducto(producto))
                {
                    return Ok("Producto registrado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo registrar el producto");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }*/
    }
}
