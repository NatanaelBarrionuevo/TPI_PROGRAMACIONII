﻿using FarmaciaBack.Dominio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        //private ClienteDAO dao;
        public ClienteController()
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

        [HttpGet("Obrasocial")]
        public IActionResult GetObraSocial() // IActionResult devuelve un Json y un Codigo OK 200
        {/*
            if (dao.ObtenerObraSocial() != null)
            {
                return Ok(dao.ObtenerObraSocial());
            }*/
            return NoContent();
        }

        [HttpGet("Categoria")]
        public IActionResult GetTipo() // IActionResult devuelve un Json y un Codigo OK 200
        {/*
            if (dao.ObtenerCategoria() != null)
            {
                return Ok(dao.ObtenerCategoria());
            }*/
            return NoContent();
        }

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            //dentro de un try catch
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Se esperaba un cliente con todos los datos");
                }
                //if (cliente.) validaciones por si es un objeto valido.
                /*if (dao.CrearCliente(cliente))
                {
                    return Ok("Cliente registrado con exito");
                }*/
                else
                {
                    return StatusCode(500, "No se pudo registrar el cliente");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
    }
}
