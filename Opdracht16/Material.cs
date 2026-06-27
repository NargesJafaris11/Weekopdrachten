namespace Weekopdrachten.Opdracht16;

public abstract class Material
{
    protected Material(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public void Open()
    {
        Console.WriteLine($"{Title} opened.");
    }

    public void Close()
    {
        Console.WriteLine($"{Title} closed.");
    }

    public abstract void DisplayInfo();

    public override string ToString()
    {
        return $"{Title} ({Year})";
    }
}