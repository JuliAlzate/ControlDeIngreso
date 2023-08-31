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
    public class Usuario
    {
        [Key]
        public long USU_Id { get; set; }
        public string USU_NombreCompleto { get; set; }
        public string USU_NombreUsuario { get; set; }
        public string USU_Contrasena { get; set; }
        public string USU_Documento { get; set; }


        //[JsonIgnore]
        public long USU_ROL_Id { get; set; }
        [ForeignKey("USU_ROL_Id")]
        public Rol Rol { get; set; }
    }
}
