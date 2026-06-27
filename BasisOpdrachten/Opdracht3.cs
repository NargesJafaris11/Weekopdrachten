using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht3
{
    public static void Weekopdracht3()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 3: Hoger-Lager");

        var secretNumber = Random.Shared.Next(1, 100);
        var guess = 0;
        var attempts = 0;

        while (guess != secretNumber)
        {
            Console.Write("Raad een getal tussen 1 en 99: ");

            var isValidNumber = int.TryParse(Console.ReadLine(), out guess);

            if (!isValidNumber)
            {
                Console.WriteLine("Ongeldige invoer.");
                continue;
            }

            attempts++;

            if (guess < secretNumber)
                Console.WriteLine("Hoger!");
            else if (guess > secretNumber) Console.WriteLine("Lager!");
        }

        Console.WriteLine();
        Console.WriteLine($"Gefeliciteerd! Je hebt het getal geraden in {attempts} pogingen.");

        ConsoleHelper.Pause();
    }
}