using ControlAccesoP.Core.DTOs;
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
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ControlAccesoContext _context;

        public PersonaRepository(ControlAccesoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Persona>> GetPersonas()
        {
            var persona = await _context.Persona
                .OrderByDescending(x => x.PER_Id)
                .Include(a => a.TipoDocumento)
                .Select(a => new Persona
                {
                    PER_Cedula = a.PER_Cedula,
                    PER_PrimerNombre = a.PER_PrimerNombre,
                    PER_SegundoNombre = a.PER_SegundoNombre,
                    PER_PrimerApellido = a.PER_PrimerApellido,
                    PER_SegundoApellido = a.PER_SegundoApellido,
                    PER_FechaNacimiento = a.PER_FechaNacimiento,
                    PER_Sexo = a.PER_Sexo,
                    PER_TID_Id = a.TipoDocumento.TID_Id
                }).ToListAsync();
            return persona;
        }


        public  async Task<Persona> PersonaReg(string id)
        {
            var a = await _context.Persona.Where(x => x.PER_Cedula == id).FirstOrDefaultAsync();
            return a;
        }


        public async  Task<Persona> GetPersonaDocumento(string cedula)
        { 
            var personaDocumento = await  _context.Persona.Where(x => x.PER_Cedula == cedula).FirstOrDefaultAsync();
            return personaDocumento;
        }

    
        public async Task<Persona> CrearPersona(Persona persona)
        {
            _context.Persona.Add(persona);
            await _context.SaveChangesAsync();
            return persona;
        }


       

        public async  Task<Persona> CompararInformacion(Persona persona, Persona a)
        {
            _ = a.PER_PrimerNombre == persona.PER_PrimerNombre ? "" : a.PER_PrimerNombre = persona.PER_PrimerNombre;
            _ = a.PER_SegundoNombre == persona.PER_SegundoNombre ? "" : a.PER_SegundoNombre = persona.PER_SegundoNombre;
            _ = a.PER_PrimerApellido == persona.PER_PrimerApellido ? "" : a.PER_PrimerApellido = persona.PER_PrimerApellido;
            _ = a.PER_SegundoApellido == persona.PER_SegundoApellido ? "" : a.PER_SegundoApellido = persona.PER_SegundoApellido;
            _ = a.PER_FechaNacimiento == persona.PER_FechaNacimiento ? "" : a.PER_FechaNacimiento = persona.PER_FechaNacimiento;
            _ = a.PER_Sexo == persona.PER_Sexo ? "" : a.PER_Sexo = persona.PER_Sexo;
            _context.Update(a);
            await _context.SaveChangesAsync();
            return a;
        }
    }
}
