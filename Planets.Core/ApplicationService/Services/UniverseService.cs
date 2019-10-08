using System.Collections.Generic;
using System.IO;
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

        public List<Universe> GetFilteredPlanets(Filter filter)
        {
           
                if (filter.CurrentPage < 0 || filter.ItemsPrPage < 0)
                {
                    throw new InvalidDataException("page and items must be 0 or more!");
                }
                if ((filter.CurrentPage - 1 * filter.ItemsPrPage) >= _planetRepository.Count())
                {
                    throw new InvalidDataException("No Items to show!");
                }
                if (filter.ItemsPrPage > _planetRepository.Count())
                {
                    throw new InvalidDataException("the items number is to  high!");
                }
                return _planetRepository.ReadPlanets().ToList();
            
        }
    }
}