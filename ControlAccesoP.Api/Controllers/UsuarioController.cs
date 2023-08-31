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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuario(int id)
        {
            var usuario = await _usuarioRepository.GetUsuario(id);
            return Ok(usuario);
        }

        [HttpGet("api/login/{user}/{pws}")]
        public async Task<IActionResult> GetUsuario(string user, string pws)
        {
            var usuario = await _usuarioRepository.Usuario(user, pws);
            return Ok(usuario);
        }
    }
}
