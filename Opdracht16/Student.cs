namespace Weekopdrachten.Opdracht16;

public class Student : User
{
    public string StudentNumber { get; set; }
    public string StudyProgram { get; set; }

    public Student(
        string name,
        string email,
        int age,
        string studentNumber,
        string studyProgram)
        : base(name, email, age)
    {
        StudentNumber = studentNumber;
        StudyProgram = studyProgram;
    }

    public void EnrollCourse()
    {
        Console.WriteLine($"{Name} enrolled in a course.");
    }

    public override string ToString()
    {
        return $"{Name} - {StudentNumber}";
    }
}