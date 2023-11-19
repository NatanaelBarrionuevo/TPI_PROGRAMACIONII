using FarmaciaBack.Dominio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        //private EmpleadoDAO dao;
        public EmpleadoController()
        {
            //dao = new EmpleadoDAO();
        }
        [HttpGet("Sucursal")]
        public IActionResult GetSucursal() // IActionResult devuelve un Json y un Codigo OK 200
        {/*
            if (dao.Obtenersucursal() != null)
            {
                return Ok(dao.ObtenerSucursal());
            }*/
            return NoContent();
        }
        // POST api/<EmpleadoController>
        [HttpPost]
        public IActionResult Post([FromBody] Empleado empleado)
        {
            //dentro de un try catch
            try
            {
                if (empleado == null)
                {
                    return BadRequest("Se esperaba un empleado con todos los datos");
                }
                //if (empleado.) validaciones por si es un objeto valido.
                /*if (dao.CrearEmpleado(empleado))
                {
                    return Ok("Empleado registrado con exito");
                }*/
                else
                {
                    return StatusCode(500, "No se pudo registrar el empleado");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
    }
}
