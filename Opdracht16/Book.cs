namespace Weekopdrachten.Opdracht16;

public class Book : Material
{
    public Book(
        string title,
        string author,
        int year,
        int pages)
        : base(title, author, year)
    {
        Pages = pages;
    }

    public int Pages { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title} - {Pages} pages");
    }
}