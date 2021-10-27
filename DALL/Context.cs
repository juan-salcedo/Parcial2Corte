using System;
using Entity;
using Microsoft.EntityFrameworkCore;
namespace DALL
{
    public class context : DbContext
    {
        public context(DbContextOptions contextOptions) : base(contextOptions)
        {
            
        }

        public DbSet<Afiliado> afiliados { get; set; }
        public DbSet<LiquidacionMensual> liquidacionMensual{get; set;}
        public DbSet<LiquidacionIndividual> liquidacionIndividuals { get; set;}

    }
}
