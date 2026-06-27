using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht13
{
    public static void Weekopdracht13()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 13: FizzBuzzBang");
        Console.WriteLine();

        for (var i = 1; i <= 100; i++)
        {
            var output = "";

            if (i % 3 == 0)
                output += "Fizz";

            if (i % 5 == 0)
                output += "Buzz";

            if (i % 7 == 0)
                output += "Bang";

            Console.WriteLine(string.IsNullOrEmpty(output)
                ? i.ToString()
                : output);
        }

        ConsoleHelper.Pause();
    }
}