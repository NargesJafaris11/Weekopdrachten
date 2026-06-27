namespace Weekopdrachten.Opdracht16;

public class Teacher : User
{
    public Teacher(
        string name,
        string email,
        int age,
        string subject,
        int yearsExperience)
        : base(name, email, age)
    {
        Subject = subject;
        YearsExperience = yearsExperience;
    }

    public string Subject { get; set; }
    public int YearsExperience { get; set; }

    public void CreateCourse()
    {
        Console.WriteLine($"{Name} created a course.");
    }

    public override string ToString()
    {
        return $"{Name} teaches {Subject}";
    }
}