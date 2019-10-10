using Planets.Core.Entity;
using System;

namespace Planets.Infrastructure.SQL
{
    public class DbInitializer
    {
        public static void SeedDb(PlanetsCrossDisContext context)
        {
            

            var moon1 = context.Planets.Add(new Universe()
            {
                PlanetName = "Europa",
                Price = 100,
                Gravity = "0.134 G",
                MainResource = "Methane",
                Population = 5000000,
                Size = "2x smaller than Earth",
                PlanetType = Universe.PlanetTypes.Moon,
                image = "https://en.wikipedia.org/wiki/Europa_(moon)#/media/File:Europa-moon-with-margins.jpg"


            });

            var moon2 = context.Planets.Add(new Universe()
            {
                PlanetName = "MN43yQ",
                Price = 150,
                Gravity = "-2 G",
                MainResource = "Helium",
                Population = 2,
                Size = "3x bigger than Earth",
                PlanetType = Universe.PlanetTypes.Moon,
                image = "https://upload.wikimedia.org/wikipedia/commons/7/7b/Io_highest_resolution_true_color.jpg"
            });
            var moon3 = context.Planets.Add(new Universe()
            {
                PlanetName = "OP12yQ",
                Price = 100,
                Gravity = "2 G",
                MainResource = "Soil",
                Population = 3500,
                Size = "5x bigger than Earth",
                PlanetType = Universe.PlanetTypes.Moon,
                image = "https://upload.wikimedia.org/wikipedia/commons/f/f2/Ganymede_g1_true-edit1.jpg"
            });

            var planet1 = context.Planets.Add(new Universe()
            {
                PlanetName = "Pluto",
                Price = 200,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth",
                PlanetType = Universe.PlanetTypes.Planet,
                image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Pluto_in_True_Color_-_High-Res.jpg/480px-Pluto_in_True_Color_-_High-Res.jpg"
            });
            var planet2 = context.Planets.Add(new Universe()
            {
                PlanetName = "Saturn",
                Price = 250,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth",
                PlanetType = Universe.PlanetTypes.Planet,
                image = "https://upload.wikimedia.org/wikipedia/commons/6/63/Neptune_-_Voyager_2_%2829347980845%29_flatten_crop.jpg"
            });
            var planet3 = context.Planets.Add(new Universe()
            {
                PlanetName = "Neptune",
                Price = 300,
                Gravity = "2.5 G",
                MainResource = "Gas",
                Population = 4000,
                Size = "5x smaller than Earth",
                PlanetType = Universe.PlanetTypes.Planet,
                image = "https://scx2.b-cdn.net/gfx/news/hires/2015/whatsimporta.jpg"
            });

            var star1 = context.Planets.Add(new Universe()
            {
                Gravity = "50g",
                Price = 20000,
                Size = "100x Size of Earth",
                PlanetName = "HNY-350",
                MainResource = "Carbon",
                Population = 50000,
                PlanetType = Universe.PlanetTypes.Star,
                image = "https://users.physics.unc.edu/~gcsloan/fun/figures/star_agb.gif"
            });
            var star2 = context.Planets.Add(new Universe()
            {
                Gravity = "100g",
                Price = 3200,
                Size = "500x Size of Earth",
                PlanetName = "NNY-251",
                MainResource = "Plastic",
                Population = 50000,
                PlanetType = Universe.PlanetTypes.Star,
                image = "http://firstgreatexpedition.org/FGEmj/images/a/ac/Betelgeuse.jpg"
            });
            var star3 = context.Planets.Add(new Universe()
            {
                Gravity = "500g",
                Price = 41000,
                Size = "300x Size of Earth",
                PlanetName = "MOY-44",
                MainResource = "Nitrous Oxide",
                Population = 50000,
                PlanetType = Universe.PlanetTypes.Star,
                image = "https://78405a.medialib.edu.glogster.com/SqCLffi5VyEV9Qdrssv0/media/e3/e3a90fb54274d8f5cc22eabebee6d423c1c9520c/rigel-2222.jpg"
            });

            context.SaveChanges();
        }
    }
}

