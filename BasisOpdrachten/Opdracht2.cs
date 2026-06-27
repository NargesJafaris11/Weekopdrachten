using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public static class Opdracht2
{
    public static void Weekopdracht2()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 2: If-Else");
        Console.Write("Voer een cijfer in van 1,0 t/m 10,0: ");

        var isValidNumber = double.TryParse(Console.ReadLine(), out var grade);

        if (!isValidNumber || grade < 1.0 || grade > 10.0)
        {
            Console.WriteLine("Ongeldige invoer. Voer een getal in van 1,0 t/m 10,0.");
            ConsoleHelper.Pause();
            return;
        }

        if (grade < 4.0)
            Console.WriteLine("Slecht");
        else if (grade < 5.5)
            Console.WriteLine("Matig");
        else if (grade < 7.0)
            Console.WriteLine("Voldoende");
        else if (grade < 8.5)
            Console.WriteLine("Goed");
        else
            Console.WriteLine("Uitstekend");

        ConsoleHelper.Pause();
    }
}