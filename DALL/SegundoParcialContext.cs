using System;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DALL
{
    public class SegundoParcialContext: DbContext
    {
        public SegundoParcialContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Afiliados> afiliados {get; set; }
         public DbSet<LiquidacionIndividual> liquidacionindividuals {get; set; }            
          public DbSet<LiquidacionMensual> liquidacionMensual {get; set; }

    }
}
