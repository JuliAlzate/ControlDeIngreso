using ControlAccesoP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Interfaces
{
    public interface IRolRepository
    {
        Task<IEnumerable<Rol>> GetRoles();
        Task<Rol> GetRol(int id);
    }
}
