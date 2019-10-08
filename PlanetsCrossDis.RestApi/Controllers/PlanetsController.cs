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
        // GET api/planets/5
        [HttpGet("{id}")]
        public ActionResult<Universe> Get(int id)
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

        // POST api/planets
        [HttpPost]
        public ActionResult<Universe> Post([FromBody] Universe universeToAdd)
        {
            try
            {
                return Ok(_planetService.AddPlanet(universeToAdd));
            }
            catch (Exception e)
            {
                throw new InvalidOperationException();
            }
        }

        // PUT api/planets/5
        [HttpPut("{id}")]
        public ActionResult<Universe> Put(int id, [FromBody] Universe universeToUpdate)
        {
            try
            {
                return Ok(_planetService.UpdatePlanet(universeToUpdate);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException();
            }
        }

        // DELETE api/planets/5
        [HttpDelete]
        public ActionResult<Universe> Delete([FromQuery] int id)
        {
            try
            {
                return Ok(_planetService.DeletePlanet(id > 0 ? new Universe() { Id = id} : null));
            }
            catch (Exception e)
            {
                throw new InvalidOperationException();
            }
        }

    }
}