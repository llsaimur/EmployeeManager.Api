﻿using Microsoft.AspNetCore.Identity;

namespace EmployeeManager.ApiClient.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
