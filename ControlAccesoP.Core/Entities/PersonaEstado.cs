using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Entities
{
    public class PersonaEstado
    {
        [Key]
        public long PEE_Id { get; set; }

        //[JsonIgnore]
        public long PEE_PER_Id { get; set; }
        [ForeignKey("PEE_PER_Id")]
        public Persona Persona { get; set; }

        public int PEE_EST_Id { get; set; }
        [ForeignKey("PEE_EST_Id")]
        public Estado Estado { get; set; }

        public int PEE_ARE_Id { get; set; }
        [ForeignKey("PEE_ARE_Id")]
        public Area Area { get; set; }


        public List<RegistroPersona> RegistroPersona;
    }
}
