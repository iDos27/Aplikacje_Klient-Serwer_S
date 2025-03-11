using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Models.DataModels;
public class SubjectGroup
{
    public Subject Subject { get; set; } = null!;
    public int SubjectId { get; set;}
    public Group Group { get; set; } = null!;
    public int GroupId { get; set; }

}