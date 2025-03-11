using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Models.DataModels;

public class Role : IdentityRole<int>
{
    public RoleValue RoleValue { get; set; }
    public Role(string name, RoleValue value)
    {
        RoleValue = value;
        Name = name;
    }
}