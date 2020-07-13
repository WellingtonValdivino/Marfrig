using Marfrig.Domain;
using Microsoft.EntityFrameworkCore;

namespace Marfrig.Repository.Context
{
    public class MarfrigContext : DbContext
    {
        public MarfrigContext(DbContextOptions<MarfrigContext> options) : base (options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<CompraGado> CompraGados { get; set; }
        public DbSet<CompraGadoItem> CompraGadoitens { get; set; }
        public DbSet<Pecuarista> Pecuaristas { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<CompraGadoItem>()
                 .HasKey(PE => new {PE.Id});
         }
    }
}