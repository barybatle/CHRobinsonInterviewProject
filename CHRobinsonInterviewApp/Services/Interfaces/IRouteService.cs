using CHRobinsonInterviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHRobinsonInterviewApp.Services.Interfaces
{
    public interface IRouteService
    {
        public Task<RouteModel> GetRoute(string destination);
    }
}
