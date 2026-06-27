using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht7
{
    public static void Weekopdracht7()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 7: Break");
        Console.WriteLine();

        var gevonden = 0;
        var getal = 2;

        while (true)
        {
            var isPriem = true;

            for (var i = 2; i < getal; i++)
                if (getal % i == 0)
                {
                    isPriem = false;
                    break;
                }

            if (isPriem)
            {
                Console.WriteLine(getal);
                gevonden++;
            }

            if (gevonden == 10) break;

            getal++;
        }

        ConsoleHelper.Pause();
    }
}