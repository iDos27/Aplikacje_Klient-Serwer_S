using Microsoft.AspNetCore.Identity;
using SchoolRegister.Model.DataModels;
using System;
using System.ComponentModel;
namespace SchoolRegister.Models.DataModels;

public class Teacher : User
{
    public IList<Subject> Subjects { get; set; } = null!;
    public string Title { get; set; } = null!;
}