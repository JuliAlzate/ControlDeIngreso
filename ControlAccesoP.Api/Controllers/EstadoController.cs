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
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoRepository _estadoRepository;
        public EstadoController(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetEstados()
        {
            var estados = await _estadoRepository.GetEstados();
            return Ok(estados);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstado(int id)
        {
            var estado = await _estadoRepository.GetEstado(id);
            return Ok(estado);
        }
    }
}
