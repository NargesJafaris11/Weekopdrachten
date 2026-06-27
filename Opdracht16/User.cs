namespace Weekopdrachten.Opdracht16;

public class User
{
    public User(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public void Login()
    {
        Console.WriteLine($"{Name} logged in.");
    }

    public void Logout()
    {
        Console.WriteLine($"{Name} logged out.");
    }

    public void ViewProfile()
    {
        Console.WriteLine($"{Name} - {Email}");
    }

    public override string ToString()
    {
        return $"{Name} ({Email})";
    }
}