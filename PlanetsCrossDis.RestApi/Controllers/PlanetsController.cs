using System;
using Microsoft.AspNetCore.Mvc;
using Planets.Core.ApplicationService;
using Planets.Core.Entity;

namespace PlanetsCrossDis.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController : ControllerBase
    {
        private readonly IUniverse _planetService;

        public PlanetsController(IUniverse uniService)
        {
            _planetService = uniService;
        }

        //Get api/planets
        [HttpGet]
        public ActionResult<Universe> Get()
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