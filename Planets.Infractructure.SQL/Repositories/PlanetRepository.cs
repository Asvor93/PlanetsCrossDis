using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Infrastructure.SQL.Repositories
{
    public class PlanetRepository: IPlanetRepository
    {
        readonly PlanetsCrossDisContext _context;

        public PlanetRepository(PlanetsCrossDisContext context)
        {
            _context = context;
        }

        public Planet CreatePlanet(Planet planet)
        {
            _context.Attach(planet).State = EntityState.Added;
            _context.SaveChanges();
            return planet;
        }

        public IEnumerable<Planet> ReadPlanets()
        {
            return _context.Planets;
        }

        public Planet UpdatePlanet(Planet planet)
        {
            _context.Attach(planet).State = EntityState.Modified;
            _context.SaveChanges();
            return planet;
        }

        public Planet DeletePlanet(int id)
        {
            var planetToRemove = _context.Remove(new Planet{Id = id}).Entity;
            _context.SaveChanges();
            return planetToRemove;
        }
    }
}