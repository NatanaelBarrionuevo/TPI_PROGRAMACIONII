using FarmaciaBack.Dominio;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {

        public MedicoController()
        {

        }
        [HttpGet("Obrasocial")]
        public IActionResult GetObraSocial() // IActionResult devuelve un Json y un Codigo OK 200
        {
            List<ObraSocial> lista = Servicio.ObtenerIntancia().ConsultarObraSocial();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }
        // POST api/<MedicoController>
        [HttpPost]
        public IActionResult Post([FromBody] Medico medico)
        {
            //dentro de un try catch
            try
            {
                if (medico == null)
                {
                    return BadRequest("Se esperaba un medico con todos los datos");
                }
                //if (medico.) validaciones por si es un objeto valido.
                /*if (dao.CrearMedico(medico))
                {
                    return Ok("Medico registrado con exito");
                }*/
                else
                {
                    return StatusCode(500, "No se pudo registrar el medico");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
    }
}
