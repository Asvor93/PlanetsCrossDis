using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planets.Core.ApplicationService;
using Planets.Core.Entity;

namespace PlanetsCrossDis.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController : ControllerBase
    {
        private readonly IPlanetService _planetService;

        public PlanetsController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        //Get api/planets
        [HttpGet]
        public ActionResult<Planet> Get()
        {
            try
            {
                return Ok(_planetService.GetPlanets());
            }
            catch (Exception e)
            {
                throw new InvalidOperationException();
            }
            
        }
    }
}