
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
    public class EstadoRepository : IEstadoRepository
    {
        private readonly ControlAccesoContext _context;

        public EstadoRepository(ControlAccesoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Estado>> GetEstados()
        {
            var estados = await _context.Estado.ToListAsync();
            return estados;
        }

        public async Task<Estado> GetEstado(int id)
        {
            var estado = await _context.Estado.FirstOrDefaultAsync(x => x.EST_Id == id);
            return (estado);
        }

      
    }
}
