namespace SchoolRegister.Models.DataModels;

public class Group 
{
    public int Id { get; set;}
    public string Name { get; set;} = null!;
    public IList<Student> Students { get; set;} = null!;
    public IList<SubjectGroup> SubjectGroups { get; set;} = null!;
}