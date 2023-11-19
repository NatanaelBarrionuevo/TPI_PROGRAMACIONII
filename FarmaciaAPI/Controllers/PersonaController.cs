using FarmaciaBack.Dominio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        //private PersonasDAO dao;
        public PersonaController()
        {
            //dao = new PersonasDAO();
        }
        [HttpGet("Barrios")]
        public IActionResult GetBarrios() // IActionResult devuelve un Json y un Codigo OK 200
        {/*
            if (dao.ObtenerBarrios() != null)
            {
                return Ok(dao.ObtenerBarrios());
            }*/
            return NoContent();
        }
        // POST api/<PersonasController>
        [HttpPost]
        public IActionResult Post([FromBody] Persona persona)
        {
            //dentro de un try catch
            try
            {
                if (persona == null)
                {
                    return BadRequest("Se esperaba una persona con todos los datos");
                }
                //if (persona.) validaciones por si es un objeto valido.
                /*if (dao.CrearPersona(persona))
                {
                    return Ok("Persona registrada con exito");
                }*/
                else
                {
                    return StatusCode(500, "No se pudo registrar la persona");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
    }
}
