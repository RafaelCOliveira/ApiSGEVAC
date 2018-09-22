using ApiSGEVAC.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSGEVAC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Montadora> Montadora { get; set; }
        public DbSet<MotivoCancelamento> MotivoCancelamento { get; set; }
        
        
    }
}