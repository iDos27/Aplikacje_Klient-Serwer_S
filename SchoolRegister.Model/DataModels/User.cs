using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels;
public class User : IdentityUser<int>
{
    public required string FirstName { get; set; }
    public string LastName { get; set; } = null!; 
     public DateTime RegistrationDate { get; set; } = DateTime.Now;
}