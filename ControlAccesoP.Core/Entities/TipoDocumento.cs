using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Entities
{
    public class TipoDocumento
    {
        [Key]
        public long TID_Id { get; set; }
        public string TID_Descripcion { get; set; }
        public List<Persona> Personas { get; set; }
    }
}
