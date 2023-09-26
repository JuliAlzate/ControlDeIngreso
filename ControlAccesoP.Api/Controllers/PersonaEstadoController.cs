using ControlAccesoP.Core.Entities;
using ControlAccesoP.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControlAccesoP.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class PersonaEstadoController : ControllerBase
    {
        private readonly IPersonaEstadoRepository _personaEstadoRepository;
        private readonly IPersonaRepository _personaRepository;
        private readonly IRegistroPersonaRepository _registroPersonaRepository;
        
        public PersonaEstadoController(IPersonaEstadoRepository personaEstadoRepository, IPersonaRepository personaRepository, IRegistroPersonaRepository registroPersonaRepository)
        {
            
            _personaEstadoRepository = personaEstadoRepository;
            _personaRepository = personaRepository;
            _registroPersonaRepository = registroPersonaRepository;
        }

        [HttpPost("api/registro2")]
        public async Task<IActionResult> InsertPersonaEstadoVisitante([FromBody] Persona persona)
        {
            var personaDocumento = await _personaRepository.GetPersonaDocumento(persona.PER_Cedula);
            if (personaDocumento==null)
            {
                var personaCreada= await _personaRepository.CrearPersona(persona);
                var personaEstado = await _personaEstadoRepository.PostPersonaEstado((int)personaCreada.PER_Id);
                var registroPersona = await _registroPersonaRepository.PostRegistroPersona(personaEstado);
                return Ok(personaEstado);
            }
            else
            {
                 await _personaRepository.CompararInformacion(persona, personaDocumento);
                var personaEstado = await _personaEstadoRepository.GetPersonaEstado((int)personaDocumento.PER_Id);
                if (personaEstado.PEE_EST_Id==3)
                {
                    var registroPersona = await _registroPersonaRepository.PostRegistroPersona(personaEstado);
                    return Ok(personaEstado);
                }
                if (personaEstado.PEE_EST_Id == 2)
                {
                    return Ok(personaEstado);
                }
                return Ok(personaEstado);    
            }
                
        }
    }
}
