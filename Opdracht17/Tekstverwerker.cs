namespace Weekopdrachten.Opdracht17;

public static class Tekstverwerker
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 17-3: Tekstverwerker");
        Console.WriteLine("Typ tekst en druk op Enter.");
        Console.WriteLine("Typ alleen z en druk op Enter = Undo");
        Console.WriteLine("Typ alleen y en druk op Enter = Redo");
        Console.WriteLine("Typ alleen q en druk op Enter = Stoppen");
        Console.WriteLine();

        // Stack gekozen omdat undo/redo werkt volgens LIFO:
        // de laatste letter wordt als eerste ongedaan gemaakt.
        Stack<char> tekst = new();
        Stack<char> redo = new();

        while (true)
        {
            Console.Write("Invoer: ");
            var invoer = Console.ReadLine() ?? "";

            if (invoer == "q") break;

            if (invoer == "z")
            {
                if (tekst.Count > 0) redo.Push(tekst.Pop());
            }
            else if (invoer == "y")
            {
                if (redo.Count > 0) tekst.Push(redo.Pop());
            }
            else
            {
                foreach (var letter in invoer)
                    if (letter >= 'a' && letter <= 'z')
                        tekst.Push(letter);

                redo.Clear();
            }

            Console.Write("Tekst: ");

            foreach (var letter in tekst.Reverse()) Console.Write(letter);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}