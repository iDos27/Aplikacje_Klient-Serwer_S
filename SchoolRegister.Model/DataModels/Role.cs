using Microsoft.AspNetCore.Identity;
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