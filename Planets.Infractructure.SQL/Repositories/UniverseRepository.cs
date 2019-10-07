using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Infrastructure.SQL.Repositories
{
    public class UniverseRepository: IUniverseRepository
    {
        readonly PlanetsCrossDisContext _context;

        public UniverseRepository(PlanetsCrossDisContext context)
        {
            _context = context;
        }

        public Universe CreatePlanet(Universe planet)
        {
            _context.Attach(planet).State = EntityState.Added;
            _context.SaveChanges();
            return planet;
        }

        public IEnumerable<Universe> ReadPlanets()
        {
            return _context.Planets;
        }

        public Universe UpdatePlanet(Universe planet)
        {
            _context.Attach(planet).State = EntityState.Modified;
            _context.SaveChanges();
            return planet;
        }

        public Universe DeletePlanet(int id)
        {
            var planetToRemove = _context.Remove(new Universe { Id = id}).Entity;
            _context.SaveChanges();
            return planetToRemove;
        }
    }
}