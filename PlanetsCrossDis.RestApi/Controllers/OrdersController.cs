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

    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        //Get api/orders
        [HttpGet]
        public ActionResult<Order> Get()
        {
            try
            {
                return Ok(_orderService.ReadAllOrders());
            }
            catch (Exception e)
            {
                throw new InvalidOperationException();
            }
        }
    }
}