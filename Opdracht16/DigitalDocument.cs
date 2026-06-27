namespace Weekopdrachten.Opdracht16;

public class DigitalDocument : Material
{
    public DigitalDocument(
        string title,
        string author,
        int year,
        string fileType)
        : base(title, author, year)
    {
        FileType = fileType;
    }

    public string FileType { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Document: {Title} ({FileType})");
    }
}