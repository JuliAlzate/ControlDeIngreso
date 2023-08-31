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
    //[Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaController(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        [HttpGet("api/registro")]
        public async Task<IActionResult> GetPersonas()
        {
            var personas = await _personaRepository.GetPersonas();
            return Ok(personas);
        }
        //[HttpPost("api/registro")]
        //public async Task<IActionResult> RegistroPersona([FromBody] Persona persona)
        //{
        //    var pers = await _personaRepository.RegiPersona(persona);

        //    return Ok(pers);
        //}
        [HttpGet("api/documento/{ced}")]
        public async Task<IActionResult> GetPersonasDoc(string ced)
        {
            var personasRe = await _personaRepository.PersonaReg(ced);
            return Ok(personasRe);
        }


    }
}
