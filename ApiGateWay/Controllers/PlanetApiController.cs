using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateWay.Controllers
{

    [ApiController]
    [Route("api/planets")]
    public class PlanetApiController : ControllerBase
    {

        [HttpGet]

        public async Task<ActionResult> GetPlanetsAsync()
        {
            try
            {
                var apiClient = HttpClientFactory.Create();

                var url = "http://localhost:5011/api/planets";
                var result = await apiClient.GetStringAsync(url);

                return Ok(result);
            }
            catch (Exception ex)
            {
                //Some cool logging mechanism 
                Console.Write("Error at getting the planets: " + ex.Message);
                return StatusCode(500, "An error occurred");
            }
        }
    }
}
