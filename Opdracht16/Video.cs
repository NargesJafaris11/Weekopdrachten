namespace Weekopdrachten.Opdracht16;

public class Video : Material
{
    public Video(
        string title,
        string author,
        int year,
        int durationMinutes)
        : base(title, author, year)
    {
        DurationMinutes = durationMinutes;
    }

    public int DurationMinutes { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Video: {Title} - {DurationMinutes} minutes");
    }
}