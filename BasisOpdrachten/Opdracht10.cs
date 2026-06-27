using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht10
{
    public static void Weekopdracht10()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 10: Quiz");
        Console.WriteLine();

        var score = 0;

        Console.WriteLine("Vraag 1: Wat is de hoofdstad van Nederland?");
        Console.WriteLine("a) Rotterdam");
        Console.WriteLine("b) Amsterdam");
        Console.WriteLine("c) Utrecht");
        var antwoord1 = (Console.ReadLine() ?? "").ToLower().Trim();

        if (antwoord1 == "b" || antwoord1 == "amsterdam")
        {
            score++;
            Console.WriteLine("Goed!");
        }
        else
        {
            Console.WriteLine("Fout!");
        }

        Console.WriteLine();

        Console.WriteLine("Vraag 2: Hoeveel dagen heeft een week?");
        Console.WriteLine("a) 5");
        Console.WriteLine("b) 6");
        Console.WriteLine("c) 7");
        var antwoord2 = (Console.ReadLine() ?? "").ToLower().Trim();

        if (antwoord2 == "c" || antwoord2 == "7")
        {
            score++;
            Console.WriteLine("Goed!");
        }
        else
        {
            Console.WriteLine("Fout!");
        }

        Console.WriteLine();

        Console.WriteLine("Vraag 3: Welke taal gebruiken we hier?");
        Console.WriteLine("a) C#");
        Console.WriteLine("b) Java");
        Console.WriteLine("c) Python");
        var antwoord3 = (Console.ReadLine() ?? "").ToLower().Trim();

        if (antwoord3 == "a" || antwoord3 == "c#" || antwoord3 == "csharp")
        {
            score++;
            Console.WriteLine("Goed!");
        }
        else
        {
            Console.WriteLine("Fout!");
        }

        Console.WriteLine();

        Console.WriteLine("Vraag 4: Hoeveel maanden heeft een jaar?");
        Console.WriteLine("a) 10");
        Console.WriteLine("b) 12");
        Console.WriteLine("c) 14");
        var antwoord4 = (Console.ReadLine() ?? "").ToLower().Trim();

        if (antwoord4 == "b" || antwoord4 == "12")
        {
            score++;
            Console.WriteLine("Goed!");
        }
        else
        {
            Console.WriteLine("Fout!");
        }

        Console.WriteLine();

        Console.WriteLine("Vraag 5: Welk keyword gebruik je om een klasse te laten erven van een andere klasse?");
        Console.WriteLine("a) inherits");
        Console.WriteLine("b) extends");
        Console.WriteLine("c) :");
        var antwoord5 = (Console.ReadLine() ?? "").ToLower().Trim();

        if (antwoord5 == "c" || antwoord5 == ":")
        {
            score++;
            Console.WriteLine("Goed!");
        }
        else
        {
            Console.WriteLine("Fout!");
        }

        Console.WriteLine();
        Console.WriteLine($"Je score is: {score}/5");

        ConsoleHelper.Pause();
    }
}