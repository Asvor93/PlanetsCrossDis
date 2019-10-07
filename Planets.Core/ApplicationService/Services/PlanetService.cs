using System.Collections.Generic;
using System.Linq;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Core.ApplicationService.Services
{
    public class PlanetService: IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }
        public List<Planet> GetPlanets()
        {
            return _planetRepository.ReadPlanets().ToList();
        }

        public Planet AddPlanet(Planet planetToAdd)
        {
            return _planetRepository.CreatePlanet(planetToAdd);
        }

        public Planet DeletePlanet(Planet planetToDelete)
        {
            return _planetRepository.DeletePlanet(planetToDelete.Id);
        }

        public Planet UpdatePlanet(Planet planetToUpdate)
        {
            return _planetRepository.UpdatePlanet(planetToUpdate);
        }
    }
}