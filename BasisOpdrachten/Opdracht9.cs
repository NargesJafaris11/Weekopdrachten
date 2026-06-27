using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht9
{
    public static void Weekopdracht9()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 9: Ternary Operator");
        Console.Write("Voer een score in (0-100): ");

        var isValid = int.TryParse(Console.ReadLine(), out var score);

        if (!isValid || score < 0 || score > 100)
        {
            Console.WriteLine("Ongeldige invoer.");
            ConsoleHelper.Pause();
            return;
        }

        var beoordeling =
            score < 50 ? "Slecht" :
            score < 65 ? "Matig" :
            score < 75 ? "Voldoende" :
            score < 90 ? "Goed" :
            "Uitstekend";

        Console.WriteLine($"Beoordeling: {beoordeling}");

        ConsoleHelper.Pause();
    }
}