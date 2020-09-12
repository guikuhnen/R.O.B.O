using System;
using System.Net;
using API.ROBO.DTOs;
using API.ROBO.Models;
using API.ROBO.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.ROBO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControlaRoboController : ControllerBase
    {
        // Robo estatico
        public static Robo _robo = new Robo();

        [HttpGet]
        public RoboDTO Get()
        {
            return new RoboDTO(_robo);
        }

        [HttpPost]
        public ActionResult Post([FromBody] RoboDTO value)
        {
            try
            {
                var validarComandosRobo = new ControlaRoboService().ValidarComandosRobo(value, _robo);
                if (!string.IsNullOrEmpty(validarComandosRobo))
                    return StatusCode((int)HttpStatusCode.BadRequest, validarComandosRobo);

                _robo = new ControlaRoboService().ExecutarComandosRobo(value);

                return StatusCode((int)HttpStatusCode.NoContent);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, !string.IsNullOrEmpty(e.Message) ? e.Message : "Internal Server Error");
            }
        }
    }
}
