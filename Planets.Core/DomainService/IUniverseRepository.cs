using System.Collections.Generic;
using Planets.Core.Entity;

namespace Planets.Core.DomainService
{
    public interface IUniverseRepository
    {
        Universe CreatePlanet(Universe universe);
        IEnumerable<Universe> ReadPlanets(Filter filter = null);
        Universe UpdatePlanet(Universe universe);
        Universe DeletePlanet(int id);
        int Count();
    }
}