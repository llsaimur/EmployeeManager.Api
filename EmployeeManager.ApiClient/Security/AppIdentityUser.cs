using Microsoft.AspNetCore.Identity;

namespace EmployeeManager.ApiClient.Security
{
    public class AppIdentityUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
