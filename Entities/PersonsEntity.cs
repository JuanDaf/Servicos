using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PersonsEntity
    {
        [Key]
        [StringLength(15)]
        public string PersonaId { get; set; }
        [Required]
        [StringLength(20)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(30)]
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public Estrato NivelEstrato { get; set; }

        //Detalles
        public ICollection<DetallesEntity> Detalles { get; set; }
 
       
    }
    public enum Estrato
    {
        Bajo, Medio, Alto
    }
}
