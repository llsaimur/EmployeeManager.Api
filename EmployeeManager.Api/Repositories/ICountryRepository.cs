using EmployeeManager.Api.Models;

namespace EmployeeManager.Api.Repositories
{
    public interface ICountryRepository
    {
        List<Country> SelectAll();
    }
}
