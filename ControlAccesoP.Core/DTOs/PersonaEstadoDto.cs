using ControlAccesoP.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Core.DTOs
{
    public class PersonaEstadoDto //validar el estado de la persona desde el fron
    {

        public long PER_Id { get; set; }
        public string PER_Cedula { get; set; }
        public string PER_PrimerNombre { get; set; }
        public string PER_SegundoNombre { get; set; }
        public string PER_PrimerApellido { get; set; }
        public string PER_SegundoApellido { get; set; }
        public string PER_FechaNacimiento { get; set; }
        public string PER_Sexo { get; set; }

        public int EST_Id { get; set; }
        public string EST_Nombre { get; set; }
        public Estado Estado { get; set; }



        public int ARE_Id { get; set; }
        public string ARE_Nombre { get; set; }
        public bool ARE_Estado { get; set; }
        public Area Area { get; set; }
        // [JsonIgnore]
        public long PER_TID_Id { get; set; }
    }
}
