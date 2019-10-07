using System;
using System.Collections.Generic;
using System.Text;

namespace Planets.Core.Entity
{
    public class Universe
    {
        public int Id { get; set; }
        public string PlanetName { get; set; }
        public double Price { get; set; }
        public int Population { get; set; }
        public string Gravity { get; set; }
        public string Size { get; set; }
        public string MainResource { get; set; }
        public PlanetTypes PlanetType { get; set; }
        public enum PlanetTypes
        {
            Moon, Star, Planet
        }
    }
}
