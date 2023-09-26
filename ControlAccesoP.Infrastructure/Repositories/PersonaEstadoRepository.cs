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
     public class PersonaEstadoRepository : IPersonaEstadoRepository

     {
        private readonly ControlAccesoContext _context;
        public PersonaEstadoRepository(ControlAccesoContext context)
        {
            _context = context;
        }

        public async  Task<PersonaEstado>GetPersonaEstado(int id)
        {
            try
            {
                PersonaEstado estadoPersona = await _context.PersonaEstado.Include(a => a.Area).Include(e=> e.Estado).Where(x => x.PEE_PER_Id == id).OrderBy(x => x.PEE_Id).LastOrDefaultAsync();
                return estadoPersona;
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            
        }

        public async Task<PersonaEstado> PostPersonaEstado(int id)
        {
            var personaEstado = new PersonaEstado();
            personaEstado.PEE_ARE_Id = 5;
            personaEstado.PEE_EST_Id = 2;
            personaEstado.PEE_PER_Id = id;

            _context.Add(personaEstado);
            await _context.SaveChangesAsync();
            return personaEstado;
 
        }
    }
}
