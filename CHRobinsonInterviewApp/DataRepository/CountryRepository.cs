using CHRobinsonInterviewApp.DataRepository.Interfaces;
using CHRobinsonInterviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHRobinsonInterviewApp.DataRepository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly List<Country> Countries = new List<Country>()
        {
            new Country(){ Name = "Canada", Code = "CAN", Parents = new List<string>(), Children = new List<string> { "USA" } },
            new Country(){ Name = "United States", Code = "USA", Parents = new List<string>{ "CAN" }, Children = new List<string> { "MEX" } },
            new Country(){ Name = "Mexico", Code = "MEX", Parents = new List<string>{ "USA" }, Siblings = new List<string>{ "BLZ" }, Children = new List<string>{ "GTM" } },
            new Country(){ Name = "Belize", Code = "BLZ", Siblings = new List<string>{ "MEX", "GTM" } },
            new Country(){ Name = "Guatemala", Code = "GTM", Parents = new List<string>{ "MEX" }, Children = new List<string>{ "SLV", "HND" } },
            new Country(){ Name = "El Salvador", Code = "SLV", Parents = new List<string>{ "GTM" }, Siblings = new List<string>{ "HND" } },
            new Country(){ Name = "Honduras", Code = "HND", Parents = new List<string>{ "GTM" }, Siblings = new List<string>{ "SLV" }, Children = new List<string>{ "NIC" } },
            new Country(){ Name = "Nicaragua", Code = "NIC", Parents = new List<string>{ "HND" }, Children = new List<string>{ "CRI" } },
            new Country(){ Name = "Costa Rica", Code = "CRI", Parents = new List<string>{ "NIC" }, Children = new List<string>{ "PAN" } },
            new Country(){ Name = "Panama", Code = "PAN", Parents = new List<string>{ "CRI" } }
        };

        public List<Country> GetCountries()
        {
            return Countries;
        }

    }
}
