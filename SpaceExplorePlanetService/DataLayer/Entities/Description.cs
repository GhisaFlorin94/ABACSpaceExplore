using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace SpaceExplorePlanetService.DataLayer.Entities
{
    public class Description
    {
        public  int DescriptionId { get; set; }
        public string DescriptionText { get; set; }
        public string CaptainName { get; set; }
        public int CaptainId { get; set; }

    }
}
