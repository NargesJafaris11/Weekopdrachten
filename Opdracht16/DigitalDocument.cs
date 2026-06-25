namespace Weekopdrachten.Opdracht16;

public class DigitalDocument : Material
{
    public string FileType { get; set; }

    public DigitalDocument(
        string title,
        string author,
        int year,
        string fileType)
        : base(title, author, year)
    {
        FileType = fileType;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Document: {Title} ({FileType})");
    }
}