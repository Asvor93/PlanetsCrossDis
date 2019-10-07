using Planets.Core.Entity;

namespace Planets.Infrastructure.SQL
{
    public class DbInitializer
    {
        public static void SeedDb(PlanetsCrossDisContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var moon1 = context.Moons.Add(new Moon()
            {
                PlanetName = "Europa",
                Price = 100,
                Gravity = "0.134 G",
                MainResource = "Methane",
                Population = 5000000,
                Size = "2x smaller than Earth"
            });

            var moon2 = context.Moons.Add(new Moon()
            {
                PlanetName = "MN43yQ",
                Price = 150,
                Gravity = "-2 G",
                MainResource = "Helium",
                Population = 2,
                Size = "3x bigger than Earth"
            });
            var moon3 = context.Moons.Add(new Moon()
            {
                PlanetName = "OP12yQ",
                Price = 100,
                Gravity = "2 G",
                MainResource = "Soil",
                Population = 3500,
                Size = "5x bigger than Earth"
            });

            var planet1 = context.Planets.Add(new Planet()
            {
                PlanetName = "Pluto",
                Price = 200,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth"
            });
            var planet2 = context.Planets.Add(new Planet()
            {
                PlanetName = "Saturn",
                Price = 250,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth"
            });
            var planet3 = context.Planets.Add(new Planet()
            {
                PlanetName = "Neptune",
                Price = 300,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth"
            });

            var star1 = context.Stars.Add(new Star()
            {
                Gravity = "50g",
                Price = 20000,
                Size = "100x Size of Earth",
                StarName = "HNY-350"
            });
            var star2 = context.Stars.Add(new Star()
            {
                Gravity = "100g",
                Price = 3200,
                Size = "500x Size of Earth",
                StarName = "NNY-251"
            });
            var star3 = context.Stars.Add(new Star()
            {
                Gravity = "500g",
                Price = 41000,
                Size = "300x Size of Earth",
                StarName = "MOY-44"
            });
        }
    }
}

