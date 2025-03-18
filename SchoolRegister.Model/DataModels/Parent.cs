using SchoolRegister.Model.DataModels;
namespace SchoolRegister.Models.DataModels;

public class Parent : User
{
    public IList<Student> Students { get; set; } = null!;
}