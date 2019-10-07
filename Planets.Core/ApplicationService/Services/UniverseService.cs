using System.Collections.Generic;
using System.Linq;
using Planets.Core.DomainService;
using Planets.Core.Entity;

namespace Planets.Core.ApplicationService.Services
{
    public class UniverseService : IUniverse
    {
        private readonly IUniverseRepository _planetRepository;

        public UniverseService(IUniverseRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }
        public List<Universe> GetPlanets()
        {
            return _planetRepository.ReadPlanets().ToList();
        }

        public Universe AddPlanet(Universe planetToAdd)
        {
            return _planetRepository.CreatePlanet(planetToAdd);
        }

        public Universe DeletePlanet(Universe planetToDelete)
        {
            return _planetRepository.DeletePlanet(planetToDelete.Id);
        }

        public Universe UpdatePlanet(Universe planetToUpdate)
        {
            return _planetRepository.UpdatePlanet(planetToUpdate);
        }
    }
}