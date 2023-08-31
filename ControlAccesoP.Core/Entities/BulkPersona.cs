using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Entities
{
    public class BulkPersona
    {
        [Key]
        public long BUP_Id { get; set; }
        public string BUP_Documento { get; set; }
        public string BUP_Nombre { get; set; }
        public bool BUP_Estado { get; set; }
        public string BUP_FechaBukl { get; set; }

        // [JsonIgnore]
        public long BUP_LBU_Id { get; set; }
        
    }
}
