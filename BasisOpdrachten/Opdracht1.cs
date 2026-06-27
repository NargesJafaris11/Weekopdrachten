using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public static class Opdracht1
{
    public static void Weekopdracht1()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 1: Switch");
        Console.Write("Voer een cijfer in van 1 t/m 10: ");

        var isValidNumber = int.TryParse(Console.ReadLine(), out var grade);

        if (!isValidNumber || grade < 1 || grade > 10)
        {
            Console.WriteLine("Ongeldige invoer. Voer een getal in van 1 t/m 10.");
            ConsoleHelper.Pause();
            return;
        }

        switch (grade)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Slecht");
                break;
            case 4:
            case 5:
                Console.WriteLine("Matig");
                break;
            case 6:
                Console.WriteLine("Voldoende");
                break;
            case 7:
            case 8:
                Console.WriteLine("Goed");
                break;
            case 9:
            case 10:
                Console.WriteLine("Uitstekend");
                break;
        }

        ConsoleHelper.Pause();
    }
}