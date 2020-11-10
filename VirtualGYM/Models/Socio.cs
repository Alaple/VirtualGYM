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
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public Objetivo IdObjetivo { get; set; }
        public Empresa IdEmpresa { get; set; }
    }
}
