using CHRobinsonInterviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHRobinsonInterviewApp.DataRepository.Interfaces
{
    public interface ICountryRepository
    {
        List<Country> GetCountries();
    }
}
