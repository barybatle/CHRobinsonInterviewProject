using CHRobinsonInterviewApp.Models;
using CHRobinsonInterviewApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHRobinsonInterviewApp.Controllers
{
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IRouteService RouteService;
        public RouteController(IRouteService routeService)
        {
            RouteService = routeService;
        }

        [HttpGet("{destination}")]
        public async Task<ActionResult<RouteModel>> GetRoute(string destination)
        {
            RouteModel route = await RouteService.GetRoute(destination.ToUpper());

            if(route == null)
            {
                return NotFound();
            }

            return Ok(route);
        }
    }
}
