using System;
using System.ComponentModel.DataAnnotations;

namespace Pedro_AP1_P1.Models
{
    public class Aportes {
        [Key]
        public int AportesId { get; set; }
        [Required(ErrorMessage ="Debe ingresar el Nombre de la persona")]
        public DateTime Fecha{get; set;} = DateTime.Now;
        public string Persona { get; set; }
        [Required(ErrorMessage ="Agrege una onservacion")]
        public string Observacion { get; set; }
        [Required(ErrorMessage ="Agrege un monto")]
        public int Monto { get; set; }
    }
}
