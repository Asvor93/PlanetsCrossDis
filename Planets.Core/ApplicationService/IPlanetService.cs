using System.Collections.Generic;
using Planets.Core.Entity;

namespace Planets.Core.ApplicationService
{
    public interface IPlanetService
    {
        List<Planet> GetPlanets();
        Planet AddPlanet(Planet planetToAdd);
        Planet DelePlanet(Planet planetToDelete);
        Planet UpdatePlanet(Planet planetToUpdate);
    }
}