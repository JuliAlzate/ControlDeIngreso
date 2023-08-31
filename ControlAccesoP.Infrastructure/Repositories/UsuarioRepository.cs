
using ControlAccesoP.Core.Entities;
using ControlAccesoP.Core.Interfaces;
using ControlAccesoP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
        
    {
        private readonly ControlAccesoContext _context;

        public UsuarioRepository(ControlAccesoContext context)
        {
            _context = context;
        }
        public async Task<Usuario> Usuario(string user, string pws)
        {


            var usuario = await _context.Usuario
               .Where(x => x.USU_NombreUsuario.Equals(user) && x.USU_Contrasena.Equals(pws))
               .Select(a => new Usuario { USU_NombreCompleto = a.USU_NombreCompleto, USU_ROL_Id = a.USU_ROL_Id })
               .FirstOrDefaultAsync();
            return usuario;

        }

        
        public async Task<Usuario> GetUsuario(int id )
        {
            var usuario = await _context.Usuario.FirstOrDefaultAsync(x => x.USU_Id == id);
            return (usuario);
        }


        /*
        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            var usuarios = await _context.Usuario.ToListAsync();
            return (usuarios);
        }
        */

    }
}
