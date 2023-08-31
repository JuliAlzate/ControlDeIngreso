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
    public class TipoDocumentoController : ControllerBase
    {
        private readonly ITipoDocumentoRepository _documentoRepository;
        public TipoDocumentoController(ITipoDocumentoRepository documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetDocumentos()
        {
            var documentos = await _documentoRepository.GetDocumentos();
            return Ok(documentos);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocumento(int id)
        {
            var documento = await _documentoRepository.GetDocumento(id);
            return Ok(documento);

        }
    }
}
