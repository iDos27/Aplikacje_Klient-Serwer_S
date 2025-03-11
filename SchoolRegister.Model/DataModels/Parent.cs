using Microsoft.AspNetCore.Identity;
using SchoolRegister.Model.DataModels;
using System;
using System.ComponentModel;
namespace SchoolRegister.Models.DataModels;

public class Parent : User
{
    public IList<Student> Students { get; set; } = null!;
}