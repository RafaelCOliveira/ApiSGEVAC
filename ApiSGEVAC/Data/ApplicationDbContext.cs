using ApiSGEVAC.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSGEVAC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Montadora> Montadora { get; set; }
        public DbSet<MotivoCancelamento> MotivoCancelamento { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Pessoa> Pessoa  { get; set; }

        /* 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Cargo>()
            .HasMany<Funcionario>(g => g.Funcionario)
            .WithOne(e => e.Cargo)
            .HasForeignKey(e => e.IdCargo);

            modelBuilder.Entity<Funcionario>()
            .HasOne<Cargo>(e => e.Cargo)
            .WithMany(g => g.Funcionario)
            .HasForeignKey(e => e.IdCargo);
        }
        */
    }
}