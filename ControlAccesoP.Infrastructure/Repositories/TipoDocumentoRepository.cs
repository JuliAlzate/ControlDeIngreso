
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
   public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        private readonly ControlAccesoContext _context;
        public TipoDocumentoRepository(ControlAccesoContext context)
        {
            _context= context;
        }
        public async Task<IEnumerable<TipoDocumento>> GetDocumentos()
        {
            var documentos = await _context.TipoDocumento.ToListAsync();
            return documentos;
        }
        public async  Task<TipoDocumento> GetDocumento(int id)
        {

            var documento =await  _context.TipoDocumento.FirstOrDefaultAsync(x => x.TID_Id == id);
            return documento;
        }

      
    }
}
