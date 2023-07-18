using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DetallesEntity
    {
        [Key]
        public Guid DetalleId { get; set; }
        [Required]
        public Guid ServicioId { get; set; }
        public ServicesEntity Services { get; set; }    

        [Required]
        public string PersonaId { get; set; }
        public PersonsEntity Persons { get; set; }
    }
}
