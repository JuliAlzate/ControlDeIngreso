using ControlAccesoP.Core.Entities;
using ControlAccesoP.Core.Interfaces;
using ControlAccesoP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlAccesoP.Infrastructure.Repositories
{
    public class RolRepository : IRolRepository
    {
        private readonly ControlAccesoContext _context;

        public RolRepository( ControlAccesoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Rol>> GetRoles()
        {
            var roles = await _context.Rol.ToListAsync();
            return roles;
        }
        public async Task<Rol> GetRol(int id)
        {
            var rol = await _context.Rol.FirstOrDefaultAsync(x => x.ROL_Id==id);
            return rol;
        }

       
    }
}
