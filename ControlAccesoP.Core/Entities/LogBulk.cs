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
    public class LogBulk
    {
        [Key]
        public long LBU_Id { get; set; }
        public string LBU_Tipo { get; set; }
        public bool LBU_Resultado { get; set; }
        public string LBU_FechaArchivo { get; set; }
        public string LBU_FechaBulk { get; set; }
        public string LBU_Observacion { get; set; }

        [JsonIgnore]
        public int LBU_ARE_Id { get; set; }
        [ForeignKey("LBU_ARE_Id")]
        public Area Area { get; set; }
    }
}
