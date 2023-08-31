using ControlAccesoP.Core.DTOs;
using ControlAccesoP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Interfaces
{
     public interface IRegistroPersonaRepository
    {
        Task<IEnumerable<RegistroPersonaDto>> GetRegistroPersona();

        Task<RegistroPersona> PostRegistroPersona(PersonaEstado personaEstado);

    }
}
