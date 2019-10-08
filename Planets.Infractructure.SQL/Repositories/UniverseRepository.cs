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

        public int Count()
        {
            return _context.Planets.Count();
        }

        public IEnumerable<Universe> ReadPlanets(Filter filter)
        {
            if (filter.CurrentPage > 0 && filter.ItemsPrPage > 0)
            {
                return _context.Planets.Skip((filter.CurrentPage - 1)
                                            * filter.ItemsPrPage).Take(filter.ItemsPrPage).OrderBy(p => p.PlanetName);
            }
            return _context.Planets;
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