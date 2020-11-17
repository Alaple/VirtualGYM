using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualGYM.Models
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(30)]
        public string Direccion { get; set; }
        [Required]
        [Phone]
        public string Telefono { get; set; }
        [Required]
        [EmailAddress]
        public string Mail { get; set; }
        public List<Oferta> IdOfertas { get; set; }
        public List<Socio> IdSocios { get; set; }
        public List<Clase> IdClases { get; set; }
        public List<Rutina> IdRutinas { get; set; }
    }
}
