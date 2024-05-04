using EmployeeManager.Api.Models;
using EmployeeManager.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Api.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryRepository countryRepository = null;
        public CountriesController(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        [HttpGet]
        public List<Country> Get()
        {
            return countryRepository.SelectAll();
        }
    }
}
