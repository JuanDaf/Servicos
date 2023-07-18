using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ServicesEntity
    {
        [Key]
        public Guid ServicioId { get; set; }
        [Required]
        [StringLength(60)]
        public string NommbreServicio { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public string DescripcionServicio { get; set; }

        //Detalles
        public ICollection<DetallesEntity> Detalles { get; set; }   
    }
}
