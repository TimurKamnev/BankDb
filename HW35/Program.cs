using HW35;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Net;

using BankDbContext db = new BankDbContext();
{
    Managers managerIt = new Managers
    {
        FirstName = "Ermek",
        LastName = "Abilov"
    };

    Departments it = new Departments
    {
        DepartmentName = "IT",
        Managers = managerIt
    };

    Clients firstCllient = new Clients
    {
        PassportId = "MM9090",
        FirstName = "John",
        LastName = "Abilov",
        Gender = 'M',
        Age = 22,
        DateOfBirth = new DateTime(1999, 7, 10),
        CreditRating = 10,
        TelephoneNumber = 996_702_11_22_33,
        Address = "Toktogula, 12",
        Departments = it
    };
    Clients secondClient = new Clients
    {
        PassportId = "MM1010",
        FirstName = "Sina",
        LastName = "Naruto",
        Gender = 'M',
        Age = 59,
        DateOfBirth = new DateTime(1963, 9, 10),
        CreditRating = 9,
        TelephoneNumber = 996_909_22_33_11,
        Address = "Sovietskaya, 22",
        Departments = it
    };
    Employees coder = new Employees
    {
        FirstName = "David",
        LastName = "Petrov",
        HireDate = new DateTime(2016, 11, 10),
        Departments = it

    };
   
  

    db.Clients.AddRange(firstCllient, secondClient);
    db.Employees.Add(coder);
    db.Departments.Add(it);
    db.Managers.Add(managerIt);

    db.SaveChanges();
}