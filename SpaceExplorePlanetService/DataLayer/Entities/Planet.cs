using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using SpaceExplorePlanetService.DataLayer.Enums;

namespace SpaceExplorePlanetService.DataLayer.Entities
{
    public class Planet
    {
        public int PlanetId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int? DescriptionId { get; set; }
        public Description Description { get; set; }
        public virtual List<Robot> ExploreRobots {get; set; }
        public PlanetStatus PlanetStatus { get; set; }
    }
}
