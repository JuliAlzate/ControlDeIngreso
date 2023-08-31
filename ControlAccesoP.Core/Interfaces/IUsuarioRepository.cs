
using ControlAccesoP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Interfaces
{
     public interface IUsuarioRepository
    {
      
        Task<Usuario> Usuario(string user, string pws);
        Task<Usuario> GetUsuario(int id);

        //Task<IEnumerable<Usuario>> GetUsuarios();

    }
}
