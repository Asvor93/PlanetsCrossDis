using System.Collections.Generic;
using Planets.Core.Entity;

namespace Planets.Core.ApplicationService
{
    public interface IUniverse
    {
        List<Universe> GetPlanets();
        Universe AddPlanet(Universe planetToAdd);
        Universe DeletePlanet(Universe planetToDelete);
        Universe UpdatePlanet(Universe planetToUpdate);
    }
}