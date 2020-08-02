using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SpaceExplorePlanetService.DataLayer;
using SpaceExplorePlanetService.DataLayer.Entities;

namespace SpaceExplorePlanetService.Controllers
{
    [Route("api/planets")]
    [ApiController]
    public class PlanetController: ControllerBase
    {
        [HttpGet]

        public ActionResult GetPlanets()
        {
            try
            {
                
                using var _context = new PlanetServiceDBContext();
                return Ok(_context.Planets.ToList());
            }
            catch (Exception ex)
            {
                //Some cool logging mechanism 
                Console.Write("Error at getting the planets: " + ex.Message);
                return StatusCode(500, "An error occurred");
            }
        }
        [HttpPut]
        public ActionResult UpdatePlanet([FromBody] Planet planet)
        {
            try
            {
                using var _context = new PlanetServiceDBContext();
                _context.Update(planet);
                return Ok();
            }
            catch (Exception ex)
            {
                //Some cool logging mechanism 
                Console.Write("Error at updating the planet: " + ex.Message);
                return StatusCode(500, "An error occurred");
            }
        }




    }
}
