using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualGYM.Models
{
    public class Rutina_Objetivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Completada { get; set; }
        public List<Rutina> IdRutinas { get; set; }
        public List<Objetivo> IdObjetivos { get; set; }
    }
}
