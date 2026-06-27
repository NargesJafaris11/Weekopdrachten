using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht8
{
    public static void Weekopdracht8()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 8: Continue");
        Console.WriteLine();

        for (var i = 1; i <= 50; i++)
        {
            if (i % 3 == 0) continue;

            Console.WriteLine(i);
        }

        ConsoleHelper.Pause();
    }
}