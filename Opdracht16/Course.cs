namespace Weekopdrachten.Opdracht16;

public class Course
{
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }

    public Course(string name, Teacher teacher)
    {
        Name = name;
        Teacher = teacher;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void ShowStudents()
    {
        foreach (Student student in Students)
        {
            Console.WriteLine(student);
        }
    }

    public override string ToString()
    {
        return $"{Name} - Teacher: {Teacher.Name}";
    }
}