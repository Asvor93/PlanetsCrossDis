

using Planets.Core.Entity;
using System.Collections.Generic;

namespace Planets.Infrastructure.SQL
{
    public class DbInitializer
    {
        int id = 1;
        List<Moon> _moons = new List<Moon>();
        List<Planet> _planets = new List<Planet>();
        List<Star> _stars = new List<Star>();

        public void InitData()
        {
            var moon1 = new Moon()
            {
               Id = id++,
               PlanetName = "Europa",
               Price = 100,
               Gravity = "0.134 G",
               MainResource = "Methane",
               Population = 5000000,
               Size = "2x smaller than Earth"
            };
            var moon2 = new Moon()
            {
                Id = id++,
                PlanetName = "MN43yQ",
                Price = 150,
                Gravity = "-2 G",
                MainResource = "Helium",
                Population = 2,
                Size = "3x bigger than Earth"
            };
            var moon3 = new Moon()
            {
                Id = id++,
                PlanetName = "OP12yQ",
                Price = 100,
                Gravity = "2 G",
                MainResource = "Soil",
                Population = 3500,
                Size = "5x bigger than Earth"
            };

            _moons.Add(moon1);
            _moons.Add(moon2);
            _moons.Add(moon3);

            var planet1 = new Planet()
            {
                Id = id++,
                PlanetName = "Pluto",
                Price = 200,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth"
            };
            var planet2 = new Planet()
            {
                Id = id++,
                PlanetName = "Saturn",
                Price = 250,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth"
            };
            var planet3 = new Planet()
            {
                Id = id++,
                PlanetName = "Neptune" +
                "",
                Price = 300,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth"
            };
            _planets.Add(planet1);
            _planets.Add(planet2);
            _planets.Add(planet3);

            var star1 = new Star()
            {
                Id = id++,
                Gravity = "50g",
                Price = 20000,
                Size = "100x Size of Earth",
                StarName = "HNY-350"
            };
            var star2 = new Star()
            {
                Id = id++,
                Gravity = "100g",
                Price = 3200,
                Size = "500x Size of Earth",
                StarName = "NNY-251"
            };
            var star3 = new Star()
            {
                Id = id++,
                Gravity = "500g",
                Price = 41000,
                Size = "300x Size of Earth",
                StarName = "MOY-44"
            };

            _stars.Add(star1);
            _stars.Add(star2);
            _stars.Add(star3);
        }


    }
}
