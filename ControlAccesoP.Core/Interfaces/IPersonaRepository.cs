using ControlAccesoP.Core.DTOs;
using ControlAccesoP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Interfaces
{
     public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetPersonas();
    
        Task<Persona> PersonaReg(string  id);
       
        Task<Persona> GetPersonaDocumento(string cedula);

        Task<Persona> CrearPersona(Persona persona);

        Task<Persona> CompararInformacion(Persona persona, Persona a);

    }
}
