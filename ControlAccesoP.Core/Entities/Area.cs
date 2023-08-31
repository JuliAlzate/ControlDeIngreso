using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.Entities
{
    public class Area
    {
        [Key]
        public int ARE_Id { get; set; }
        public string ARE_Nombre { get; set; }
        public bool ARE_Estado { get; set; }

        public List<LogBulk> LogBulk { get; set; }
    }
}
