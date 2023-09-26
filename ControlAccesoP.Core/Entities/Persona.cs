using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Entities
{
    public class Persona
    {

        [Key]
        public long PER_Id { get; set; }
        public string PER_Cedula { get; set; }= string.Empty;
        public string PER_PrimerNombre{ get; set; }=string.Empty;
        public string? PER_SegundoNombre { get; set; } 
        public string PER_PrimerApellido { get; set; } = string.Empty;
        public string PER_SegundoApellido { get; set; } = string.Empty;
        public string PER_FechaNacimiento { get; set; } = string.Empty;
        public string PER_Sexo { get; set; } = string.Empty;   

        // [JsonIgnore]
        public long? PER_TID_Id { get; set; }
        [ForeignKey("PER_TID_Id")]
        public TipoDocumento TipoDocumento { get; set; }

        //public long PER_BUP_Id { get; set; }
        //[ForeignKey("PER_BUP_Id")]
        //public BulkPersona BulkPersona { get; set; }

        public virtual List<Estado> Estados { get; set; }
    }
}
