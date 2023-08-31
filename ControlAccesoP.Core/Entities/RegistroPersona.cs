using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ControlAccesoP.Core.Entities
{
    public class RegistroPersona
    {

        [Key]
        public long REP_Id { get; set; }
        //public string REP_FechaIngreso { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public Nullable<System.DateTime> REP_FechaIngreso { get; set; }
      
        public long REP_PER_Id { get; set; }
        [ForeignKey("REP_PER_Id")]
        public Persona Persona { get; set; }
        public long REP_PEE_Id { get; set; }
        [ForeignKey("REP_PEE_Id")]
        public PersonaEstado PersonaEstado { get; set; }
    }
}
