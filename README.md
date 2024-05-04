# EmployeeManager.Api


this project shows how Employee Manager can use ASP.NET Core Web API to perform
the CRUD operations. It also shows how to use .NET Core’s HttpClient class to invoke the
API.

Functionalities:
-Signing In to Employee Manager -Creating a New User Account -Listing All the Employees -Inserting a New Employee -Updating Existing Employee -Deleting Existing Employee -Signing Out of Employee Manager

--Features used--

ASP.NET Core Web APIs:
  -Implemented two APIs: Employees and Countries.
  -CRUD operations are performed on the Employees table within the Employees API.
  -Utilized repositories to handle database operations.
  -Executed raw SQL queries and stored procedures using EF Core within the repositories.
  -Registered repositories with the DI framework using the AddScoped() method.
Client Application in ASP.NET Core MVC:
  -Built a client application using ASP.NET Core MVC.
  -Used the HttpClient class to interact with the APIs.
  -Implemented asynchronous actions in the EmployeeManagerController since HttpClient is asynchronous by design.
  -Registered HttpClient with the DI framework using the AddSingleton() method.
Data Transfer:
  -Data transfer between API and client application is done in JSON format.
