using Planets.Core.Entity;

namespace Planets.Infrastructure.SQL
{
    public class DbInitializer
    {
        public static void SeedDb(PlanetsCrossDisContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var moon1 = context.Planets.Add(new Universe()
            {
                PlanetName = "Europa",
                Price = 100,
                Gravity = "0.134 G",
                MainResource = "Methane",
                Population = 5000000,
                Size = "2x smaller than Earth",
                PlanetType = Universe.PlanetTypes.Moon

            });

            var moon2 = context.Planets.Add(new Universe()
            {
                PlanetName = "MN43yQ",
                Price = 150,
                Gravity = "-2 G",
                MainResource = "Helium",
                Population = 2,
                Size = "3x bigger than Earth",
                PlanetType = Universe.PlanetTypes.Moon
            });
            var moon3 = context.Planets.Add(new Universe()
            {
                PlanetName = "OP12yQ",
                Price = 100,
                Gravity = "2 G",
                MainResource = "Soil",
                Population = 3500,
                Size = "5x bigger than Earth",
                PlanetType = Universe.PlanetTypes.Moon
            });

            var planet1 = context.Planets.Add(new Universe()
            {
                PlanetName = "Pluto",
                Price = 200,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth",
                PlanetType = Universe.PlanetTypes.Planet
            });
            var planet2 = context.Planets.Add(new Universe()
            {
                PlanetName = "Saturn",
                Price = 250,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth",
                PlanetType = Universe.PlanetTypes.Planet
            });
            var planet3 = context.Planets.Add(new Universe()
            {
                PlanetName = "Neptune",
                Price = 300,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth",
                PlanetType = Universe.PlanetTypes.Planet
            });

            var star1 = context.Planets.Add(new Universe()
            {
                Gravity = "50g",
                Price = 20000,
                Size = "100x Size of Earth",
                PlanetName = "HNY-350",
                MainResource = "Carbon",
                Population = 50000,
                PlanetType = Universe.PlanetTypes.Star
            });
            var star2 = context.Planets.Add(new Universe()
            {
                Gravity = "100g",
                Price = 3200,
                Size = "500x Size of Earth",
                PlanetName = "NNY-251",
                MainResource = "Plastic",
                Population = 50000,
                PlanetType = Universe.PlanetTypes.Star
            });
            var star3 = context.Planets.Add(new Universe()
            {
                Gravity = "500g",
                Price = 41000,
                Size = "300x Size of Earth",
                PlanetName = "MOY-44",
                MainResource = "Nitrous Oxide",
                Population = 50000,
                PlanetType = Universe.PlanetTypes.Star
            });
        }
    }
}

