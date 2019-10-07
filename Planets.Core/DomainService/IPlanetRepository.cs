using System.Collections;
using System.Collections.Generic;
using Planets.Core.Entity;

namespace Planets.Core.DomainService
{
    public interface IPlanetRepository
    {
        Planet CreatePlanet(Planet planet);
        IEnumerable<Planet> ReadPlanets();
        Planet UpdatePlanet(Planet planet);
        Planet DeletePlanet(int id);

    }
}