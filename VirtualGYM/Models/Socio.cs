using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualGYM.Models
{
    public class Socio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string Usuario { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string Nombre { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string Apellido { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string Clave { get; set; }
        public string Sexo { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(3)]
        [Range(16, 99)]
        public int Edad { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(3)]
        [Range(10, 400)]
        public double Peso { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(3)]
        [Range(100, 250)]
        public double Altura { get; set; }
        public int IdEmpresa { get; set; }
        public Objetivo IdObjetivo { get; set; }
        public Empresa empresa { get; set; }
    }
}
