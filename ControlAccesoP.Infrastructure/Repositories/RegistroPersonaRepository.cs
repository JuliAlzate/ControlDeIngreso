using ControlAccesoP.Core.DTOs;
using ControlAccesoP.Core.Entities;
using ControlAccesoP.Core.Interfaces;
using ControlAccesoP.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Infrastructure.Repositories
{
    public class RegistroPersonaRepository : IRegistroPersonaRepository
    {
        private readonly ControlAccesoContext _context;
        public RegistroPersonaRepository(ControlAccesoContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<RegistroPersonaDto>> GetRegistroPersona()
        {
            var registroP = await _context.RegistroPersona
                .Include(x => x.Persona).OrderByDescending(x=> x.REP_FechaIngreso)
                .Where(x => x.Persona.PER_Id == x.REP_PER_Id).Select(x => new RegistroPersonaDto
            {
                Documento = x.Persona.PER_Cedula,
                Nombre = x.Persona.PER_PrimerNombre + " " + x.Persona.PER_SegundoNombre,
                Apellido = x.Persona.PER_PrimerApellido + " " + x.Persona.PER_SegundoApellido,
                Genero = x.Persona.PER_Sexo,
                FechaNacimiento = x.Persona.PER_FechaNacimiento,
                TipoDoc = x.Persona.TipoDocumento.TID_Descripcion,
                FechaDeIngreso = x.REP_FechaIngreso
               
            }).ToArrayAsync();
            return registroP;
          


        }

        public  async Task<RegistroPersona> PostRegistroPersona(PersonaEstado personaEstado)
        {
            var registroPersona = new RegistroPersona();
            try
            {
                registroPersona.REP_PEE_Id = personaEstado.PEE_Id;
                registroPersona.REP_PER_Id = personaEstado.PEE_PER_Id;
                await _context.AddAsync(registroPersona);
                await _context.SaveChangesAsync();
                return registroPersona;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return registroPersona;
            }
          


        }

       
    }
}
