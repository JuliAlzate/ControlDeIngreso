using ControlAccesoP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Interfaces
{
     public interface IPersonaEstadoRepository
    {
        Task<PersonaEstado> PostPersonaEstado(int id);
        Task<PersonaEstado> GetPersonaEstado(int id);
    }
}
