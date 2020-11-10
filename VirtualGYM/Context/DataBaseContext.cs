using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualGYM.Models;

namespace VirtualGYM.Context
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        public DbSet<Clase_Objetivo> Clases_Objetivos { get; set; }
        public DbSet<Rutina_Objetivo> Rutinas_Objetivos { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
    }
}
