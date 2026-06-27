using Weekopdrachten.Helpers;

namespace Weekopdrachten.Opdracht16;

public class Weekopdracht16
{
    public static void Run()
    {
        Console.Clear();

        var teacher = new Teacher(
            "Tom",
            "tom@school.nl",
            40,
            "C#",
            10);

        var student = new Student(
            "Narges",
            "narges@student.nl",
            30,
            "S12345",
            "HBO-ICT");

        Console.WriteLine(teacher);
        Console.WriteLine(student);

        Console.WriteLine();

        Material book = new Book(
            "C# Boek",
            "Docent",
            2024,
            250);

        Material video = new Video(
            "OOP Uitleg",
            "Docent",
            2024,
            15);

        book.DisplayInfo();
        video.DisplayInfo();

        ConsoleHelper.Pause();
    }
}