using Microsoft.EntityFrameworkCore;
using Planets.Core.Entity;

namespace Planets.Infrastructure.SQL
{
    public class PlanetsCrossDisContext: DbContext
    {
        public PlanetsCrossDisContext(DbContextOptions<PlanetsCrossDisContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Universe> Planets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}