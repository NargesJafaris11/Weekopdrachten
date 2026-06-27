using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht4
{
    public static void Weekopdracht4()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 4: Do-While");

        int number;
        bool isValid;

        do
        {
            Console.Write("Voer een getal in tussen 1 en 10: ");

            isValid = int.TryParse(Console.ReadLine(), out number);

            if (!isValid || number < 1 || number > 10) Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");
        } while (!isValid || number < 1 || number > 10);

        Console.WriteLine();
        Console.WriteLine($"Je hebt gekozen voor het getal {number}.");

        ConsoleHelper.Pause();
    }
}