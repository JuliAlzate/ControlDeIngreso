using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Entities
{
    public class Estado
    {
        [Key]
        public int EST_Id { get; set; }
        public string EST_Nombre { get; set; }
        public string EST_Descripcion { get; set; }

        public List<PersonaEstado> personaEstados { get; set; }
    }
}
