using ControlAccesoP.Core.Entities;
using ControlAccesoP.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlAccesoP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroPersonaController : ControllerBase
    {
        private readonly IRegistroPersonaRepository _registroPersona;
        public RegistroPersonaController(IRegistroPersonaRepository registroPersona)
        {
            _registroPersona = registroPersona;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegistros()
        {
            var registros = await _registroPersona.GetRegistroPersona();
            return Ok(registros);

        }
        [HttpPost]
        public  async Task<IActionResult> GuardarRetirado([FromBody] PersonaEstado personaEstado)
        {
            var registroPersona = await  _registroPersona.PostRegistroPersona(personaEstado);
            return Ok(registroPersona);
        }
    }
}
