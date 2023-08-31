using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Entities
{
    public class Rol
    {
        [Key]
        public long ROL_Id { get; set; }
        public string ROL_Nombre { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
