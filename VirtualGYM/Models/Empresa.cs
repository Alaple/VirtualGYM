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
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public List<Oferta> IdOfertas { get; set; }
        public List<Socio> IdSocios { get; set; }
        public List<Clase> IdClases { get; set; }
        public List<Rutina> IdRutinas { get; set; }
        public List<Objetivo> IdObjetivos { get; set; }
    }
}
