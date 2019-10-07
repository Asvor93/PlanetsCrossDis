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

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Moon> Universe { get; set; }
        public DbSet<Star> Stars { get; set; }
    }
}