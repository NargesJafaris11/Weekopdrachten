using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht6
{
    public static void Weekopdracht6()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 6: Foreach");
        Console.WriteLine();

        List<string> namen = new List<string>
        {
            "Anna", "Bob", "Charlie", "Dave", "Eva", "Frank", "Grace", "Harry", "Ivy", "Jack"
        };

        foreach (var naam in namen)
            if (naam.Length < 5)
                Console.WriteLine(naam);

        ConsoleHelper.Pause();
    }
}