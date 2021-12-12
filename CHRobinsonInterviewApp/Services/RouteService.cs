using CHRobinsonInterviewApp.DataRepository;
using CHRobinsonInterviewApp.DataRepository.Interfaces;
using CHRobinsonInterviewApp.Models;
using CHRobinsonInterviewApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHRobinsonInterviewApp.Services
{
    public class RouteService : IRouteService
    {
        private readonly ICountryRepository CountryRepository;
        public RouteService(ICountryRepository countryRepository)
        {
            CountryRepository = countryRepository;
        }
        public async Task<RouteModel> GetRoute(string destinationCode)
        {
            List<Country> countries = CountryRepository.GetCountries();

            if (!countries.Select(x => x.Code).Contains(destinationCode))
            {
                return null;
            }

            Country startingCountry = countries.Find(x => x.Code == "USA");
            Country destinationCountry = countries.Find(x => x.Code == destinationCode);

            List<Country> routeList = new List<Country>();

            Country currentCountry = destinationCountry;

            routeList.Insert(0, currentCountry);

            while (currentCountry.Code != startingCountry.Code)
            {
                if(currentCountry.Parents != null && currentCountry.Parents.Count > 0)
                {
                    currentCountry = countries.Find(x => x.Code == currentCountry.Parents.FirstOrDefault());
                    routeList.Insert(0, currentCountry);
                    continue;
                }

                if (currentCountry.Siblings != null && currentCountry.Siblings.Count > 0)
                {
                    currentCountry = countries.Find(x => x.Code == currentCountry.Siblings.FirstOrDefault());
                    routeList.Insert(0, currentCountry);
                    continue;
                }

                if (currentCountry.Children != null && currentCountry.Children.Count > 0)
                {
                    currentCountry = countries.Find(x => x.Code == currentCountry.Children.FirstOrDefault());
                    routeList.Insert(0, currentCountry);
                    continue;
                }
            }


            RouteModel route = new RouteModel()
            {
                Destination = destinationCode,
                List = routeList.Select(x => x.Code).ToList()
            };

            return route;
        }
    }
}
