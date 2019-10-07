using System.Collections.Generic;
using System.Linq;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Infrastructure.SQL.Repositories
{
    public class PlanetRepository: IPlanetRepository
    {
        readonly IPlanetRepository _planetRepository;

        public PlanetRepository(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public Planet CreatePlanet(Planet planet)
        {
            return _planetRepository.CreatePlanet(planet);
        }

        public IEnumerable<Planet> ReadPlanets()
        {
            return _planetRepository.ReadPlanets().ToList();
        }

        public Planet UpdatePlanet(Planet planet)
        {
            return _planetRepository.UpdatePlanet(planet);
        }

        public Planet DeletePlanet(int id)
        {
            return _planetRepository.DeletePlanet(id);
        }
    }
}